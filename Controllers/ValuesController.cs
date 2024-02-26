using EPAAPI.Models;
using Newtonsoft.Json;
using Swashbuckle.Swagger.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EPAAPI.Controllers
{
    public class EPAController : ApiController
    {
        private Model1 db = new Model1();


        /// <summary> 
        ///     統計個數
        /// </summary>
        /// <param name="city">縣市ex:新北市</param> 
        /// <param name="town">鄉鎮ex:淡水區or環保局</param> 
        /// <returns></returns> 
        /// <remarks> </remarks>
        [Route("GetCount")]
        [SwaggerResponse(HttpStatusCode.OK, "成功", typeof(Data))]
        public HttpResponseMessage GetCount(string city="ALL",string town = "ALL")
        {


            List<BASIC_DATA_VIEW> BASIC_DATA=new List<BASIC_DATA_VIEW>();
            if (city == "ALL" && town == "ALL")
            {


                var data = from a in db.BASIC_DATA
                           select new BASIC_DATA_VIEW()
                           {
                               ADMIT = a.ADMIT,
                               COUNTY_NAME = a.COUNTY_NAME,
                               xx = a.xx,
                               yy = a.yy
                           };
                 BASIC_DATA = data.ToList<BASIC_DATA_VIEW>();

            }
            else
            {
                 BASIC_DATA =( from a in db.BASIC_DATA
                                 where a.COUNTY_NAME == town && a.ADMIT == city
                                 select new BASIC_DATA_VIEW
                                 {
                                     ADMIT = a.ADMIT,
                                     COUNTY_NAME = a.COUNTY_NAME,
                                     xx = a.xx,
                                     yy = a.yy
                                 }).ToList<BASIC_DATA_VIEW>();

            }


                int VehicleCount;
                int? DisinfectorCount;
                decimal? solidDrugStateCount;
                decimal? liquidDrugStateCount;
                int ToiletCount;
                 List<Data> result = new List<Data>();
                foreach (var data in BASIC_DATA)
                {
                    VehicleCount = db.Vehicle.Count(v => v.City == data.ADMIT && v.Town == data.COUNTY_NAME);
                    DisinfectorCount = db.Disinfector.Where(v => v.City == data.ADMIT && v.Town == data.COUNTY_NAME).Sum(d => d.Amount);
                    solidDrugStateCount = db.Disinfectant.Where(v => v.City == data.ADMIT && v.Town == data.COUNTY_NAME && v.DrugState == "固體").Sum(d => d.Amount);
                    liquidDrugStateCount = db.Disinfectant.Where(v => v.City == data.ADMIT && v.Town == data.COUNTY_NAME && v.DrugState == "液體").Sum(d => d.Amount);
                    ToiletCount = db.Toilet.Count(v => v.City == data.ADMIT && v.Town == data.COUNTY_NAME);
                    Data Dataresult = new Data()
                    {
                        City = BASIC_DATA.Count() > 0 ? data.ADMIT : city,
                        Town = BASIC_DATA.Count() > 0 ? data.COUNTY_NAME : town,
                        xx = BASIC_DATA.Count() > 0 ? data.xx : null,
                        yy = BASIC_DATA.Count() > 0 ? data.yy : null,
                        Vehicle = VehicleCount,
                        Disinfector = DisinfectorCount ?? 0,
                        SolidDrugStateDisinfectant = solidDrugStateCount ?? 0,
                        LiquidDrugStateDisinfectant = liquidDrugStateCount ?? 0,
                        Toilet = ToiletCount
                    };
                    result.Add(Dataresult);
                }

              
             


                HttpResponseMessage response = this.Request.CreateResponse(HttpStatusCode.OK);
                response.Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(result), System.Text.Encoding.UTF8, "application/json");
                return response;



        }





        /// <summary> 
        ///     開口合約
        /// </summary>
        /// <returns></returns> 
        /// <remarks> </remarks>
        [Route("OpenContract")]
        [HttpGet]
        [SwaggerResponse(HttpStatusCode.OK, "成功", typeof(OPEN))]
        public HttpResponseMessage OpenContract()
        {


            var BASIC_DATASQL = from a in db.BASIC_DATA
                       select new BASIC_DATA_VIEW()
                       {
                           ADMIT = a.ADMIT,
                           COUNTY_NAME = a.COUNTY_NAME,
                           xx = a.xx,
                           yy = a.yy
                        };
           var BASIC_DATA = BASIC_DATASQL.ToList<BASIC_DATA_VIEW>();




        
            List<OPEN> result = new List<OPEN>();
            foreach (var data in BASIC_DATA)
            {
             DateTime endDate = DateTime.Now;

             var OpenContracts = from OC in db.OpenContract
                             join RT in db.ResourceType on OC.ResourceTypeId equals RT.Id
                             join CI in db.City on OC.CityId equals CI.Id
                             join TW in db.Town on OC.TownId equals TW.Id  
                             where OC.OContractDateEnd >= endDate && CI.City1== data.ADMIT&& TW.Name==data.COUNTY_NAME
                              select new OPEN
                              {
                                  ID = OC.Id,
                                  OPName = OC.Name,
                                  Name = RT.Name,
                                  Fac = OC.Fac,
                                  Owner = OC.Owner,
                                  TEL = OC.TEL,
                                  MobileTEL = OC.MobileTEL,
                                  OContractDateEnd = OC.OContractDateEnd,
                              };
                foreach (var OpenContractsdata in OpenContracts)
                {

   
                    var OpenContractDetail = from OC in db.OpenContract
                                             join OCD in db.OpenContractDetail on OC.Id equals OCD.OpenContractId
                                             where OC.Id== OpenContractsdata.ID
                                             select new Contract
                                             {
                                                 Items = OCD.Items,
                                                 Unit = OCD.Unit,
                                                 Count = OCD.Count,
                                                 Price = OCD.Price,
                                                 Budge = OCD.Budge
                                             };


                    OPEN OPENresult = new OPEN()
                    {
                        ID= OpenContractsdata.ID,
                        City = data.ADMIT,
                        TOWN = data.COUNTY_NAME,
                        xx = data.xx,
                        yy = data.yy,
                        OPName = OpenContractsdata.OPName,
                        Name = OpenContractsdata.Name,
                        Fac = OpenContractsdata.Fac,
                        Owner = OpenContractsdata.Owner,
                        TEL = OpenContractsdata.TEL,
                        MobileTEL = OpenContractsdata.MobileTEL,
                        OContractDateEnd = OpenContractsdata.OContractDateEnd,
                        contract = OpenContractDetail.ToList<Contract>()
                    };


                    result.Add(OPENresult);
                }


            }



            HttpResponseMessage response = this.Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(result), System.Text.Encoding.UTF8, "application/json");
            return response;


        }



        /// <summary> 
        ///     清潔車輛統計
        /// </summary>
        /// <returns></returns> 
        /// <remarks> </remarks>
        [Route("vehicleCount")]
        [HttpGet]
        [SwaggerResponse(HttpStatusCode.OK, "成功", typeof(vehicleCount))]
        public HttpResponseMessage vehicleCount()
        {
            var Vehicle = db.Vehicle.ToList();
            List<vehicleCount> result = (Vehicle.GroupBy(d => d._City)
                             .Select(g => new vehicleCount()
                             {
                                 City = g.Key,
                                 ALL= g.Count(),
                                 USE = g.Count(v => v.VehicleState == "使用中"),
                                 NOTUSE = g.Count(v => v.VehicleState != "使用中")
                             })).ToList();



            vehicleCount ALLresult = new vehicleCount
            {
                City = "Taiwan",
                ALL = db.Vehicle.Count(),
                USE = db.Vehicle.Count(v => v.VehicleState == "使用中"),
                NOTUSE = db.Vehicle.Count(v => v.VehicleState != "使用中")
            };


            result.Add(ALLresult);


            HttpResponseMessage response = this.Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(result), System.Text.Encoding.UTF8, "application/json");
            return response;
        }

        /// <summary> 
        ///     清潔車輛詳細
        /// </summary>
        /// <returns></returns> 
        /// <remarks> </remarks>
        [Route("vehicletable")]
        [HttpGet]
        [SwaggerResponse(HttpStatusCode.OK, "成功", typeof(Vehicle))]
        public HttpResponseMessage vehicletable(string City)
        {
            var result = db.Vehicle.ToList().Where(x => x._City == City);




            HttpResponseMessage response = this.Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(result), System.Text.Encoding.UTF8, "application/json");
            return response;
        }



























        /// <summary> 
        ///     消毒設備統計
        /// </summary>
        /// <returns></returns> 
        /// <remarks> </remarks>
        [Route("DisinfectorCount")]
        [HttpGet]
        [SwaggerResponse(HttpStatusCode.OK, "成功", typeof(DisinfectorCount))]
        public HttpResponseMessage DisinfectorCount()
        {
            List<DisinfectorCount> result = (db.Disinfector.GroupBy(d => d.City)
                                  .Select(g => new DisinfectorCount()
                                  {
                                      City = g.Key,
                                      ALL =g.Where(v => v.Amount.HasValue).Count()==0?0: g.Where(v => v.Amount.HasValue).Sum(v => v.Amount.Value),
                                      disinfection = g.Where(v => v.UseType == 1 && v.Amount.HasValue).Count() == 0 ? 0 : g.Where(v => v.UseType == 1 && v.Amount.HasValue).Sum(v => v.Amount.Value),                                     
                                      dengue = g.Where(v => v.UseType == 2 && v.Amount.HasValue).Count() == 0 ? 0 : g.Where(v => v.UseType == 2 && v.Amount.HasValue).Sum(v => v.Amount.Value),
                                      share = g.Where(v => v.UseType == 3 && v.Amount.HasValue).Count() == 0 ? 0 : g.Where(v => v.UseType == 3 && v.Amount.HasValue).Sum(v => v.Amount.Value),
                                      other = g.Where(v => v.UseType == 4 && v.Amount.HasValue).Count() == 0 ? 0 : g.Where(v => v.UseType == 4 && v.Amount.HasValue).Sum(v => v.Amount.Value),
                                  })).ToList();



            DisinfectorCount ALLresult = new DisinfectorCount
            {
                City = "Taiwan",
                ALL = db.Disinfector.Where(v => v.Amount.HasValue).Sum(v => v.Amount.Value),
                disinfection = db.Disinfector.Where(v => v.UseType == 1 && v.Amount.HasValue).Count() == 0 ? 0 : db.Disinfector.Where(v => v.UseType == 1 && v.Amount.HasValue).Sum(v => v.Amount.Value),
                dengue = db.Disinfector.Where(v => v.UseType == 2 && v.Amount.HasValue).Count() == 0 ? 0 : db.Disinfector.Where(v => v.UseType == 2 && v.Amount.HasValue).Sum(v => v.Amount.Value),
                share = db.Disinfector.Where(v => v.UseType == 3 && v.Amount.HasValue).Count() == 0 ? 0 : db.Disinfector.Where(v => v.UseType ==3 && v.Amount.HasValue).Sum(v => v.Amount.Value),
                other = db.Disinfector.Where(v => v.UseType == 4 && v.Amount.HasValue).Count() == 0 ? 0 : db.Disinfector.Where(v => v.UseType == 4 && v.Amount.HasValue).Sum(v => v.Amount.Value),
            };


            result.Add(ALLresult);


            HttpResponseMessage response = this.Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(result), System.Text.Encoding.UTF8, "application/json");
            return response;
        }








        /// <summary> 
        ///     消毒設備詳細
        /// </summary>
        /// <returns></returns> 
        /// <remarks> </remarks>
        [Route("Disinfectortable")]
        [HttpGet]
        [SwaggerResponse(HttpStatusCode.OK, "成功", typeof(Disinfector))]
        public HttpResponseMessage Disinfectortable(string City)
        {
            var result = db.Disinfector.Where(x => x.City == City);




            HttpResponseMessage response = this.Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(result), System.Text.Encoding.UTF8, "application/json");
            return response;
        }





        /// <summary> 
        ///     消毒藥劑統計
        /// </summary>
        /// <returns></returns> 
        /// <remarks> </remarks>
        [Route("DisinfectantCount")]
        [HttpGet]
        [SwaggerResponse(HttpStatusCode.OK, "成功", typeof(DisinfectantCount))]
        public HttpResponseMessage DisinfectantCount()
        {
            List<DisinfectantCount> result = (db.Disinfectant.GroupBy(d => d.City)
                                  .Select(g => new DisinfectantCount()
                                  {
                                      City = g.Key,
                                      ALL = g.Where(v => v.Amount.HasValue).Count() == 0 ? 0 : g.Where(v => v.Amount.HasValue).Sum(v => v.Amount.Value),
                                      disinfection = g.Where(v => v.UseType == 1 && v.Amount.HasValue).Count() == 0 ? 0 : g.Where(v => v.UseType == 1 && v.Amount.HasValue).Sum(v => v.Amount.Value),
                                      dengue = g.Where(v => v.UseType == 2 && v.Amount.HasValue).Count() == 0 ? 0 : g.Where(v => v.UseType == 2 && v.Amount.HasValue).Sum(v => v.Amount.Value),
                                      Fir_ants = g.Where(v => v.UseType == 3 && v.Amount.HasValue).Count() == 0 ? 0 : g.Where(v => v.UseType ==3 && v.Amount.HasValue).Sum(v => v.Amount.Value),
                                      Tessaratoma_papillosa = g.Where(v => v.UseType == 4 && v.Amount.HasValue).Count() == 0 ? 0 : g.Where(v => v.UseType ==4 && v.Amount.HasValue).Sum(v => v.Amount.Value),
                                      other = g.Where(v => v.UseType == 5 && v.Amount.HasValue).Count() == 0 ? 0 : g.Where(v => v.UseType == 5 && v.Amount.HasValue).Sum(v => v.Amount.Value),
                                  })).ToList();


  
            DisinfectantCount ALLresult = new DisinfectantCount
            {
                City = "Taiwan",
                ALL = db.Disinfectant.Where(v => v.Amount.HasValue).Count() == 0 ? 0 : db.Disinfectant.Where(v => v.Amount.HasValue).Sum(v => v.Amount.Value),
                disinfection = db.Disinfectant.Where(v => v.UseType == 1 && v.Amount.HasValue).Count() == 0 ? 0 : db.Disinfectant.Where(v => v.UseType == 1 && v.Amount.HasValue).Sum(v => v.Amount.Value),
                dengue = db.Disinfectant.Where(v => v.UseType == 2 && v.Amount.HasValue).Count() == 0 ? 0 : db.Disinfectant.Where(v => v.UseType == 2 && v.Amount.HasValue).Sum(v => v.Amount.Value),
                Fir_ants = db.Disinfectant.Where(v => v.UseType == 3 && v.Amount.HasValue).Count() == 0 ? 0 : db.Disinfectant.Where(v => v.UseType == 3 && v.Amount.HasValue).Sum(v => v.Amount.Value),
                Tessaratoma_papillosa = db.Disinfectant.Where(v => v.UseType == 4 && v.Amount.HasValue).Count() == 0 ? 0 : db.Disinfectant.Where(v => v.UseType == 4 && v.Amount.HasValue).Sum(v => v.Amount.Value),
                other = db.Disinfectant.Where(v => v.UseType == 5 && v.Amount.HasValue).Count() == 0 ? 0 : db.Disinfectant.Where(v => v.UseType == 5 && v.Amount.HasValue).Sum(v => v.Amount.Value),
            };


            result.Add(ALLresult);


            HttpResponseMessage response = this.Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(result), System.Text.Encoding.UTF8, "application/json");
            return response;
        }





        /// <summary> 
        ///     消毒藥劑詳細
        /// </summary>
        /// <returns></returns> 
        /// <remarks> </remarks>
        [Route("Disinfectanttable")]
        [HttpGet]
        [SwaggerResponse(HttpStatusCode.OK, "成功", typeof(Disinfectant))]
        public HttpResponseMessage Disinfectanttable(string City)
        {
            var result = db.Disinfectant.Where(x => x.City == City);




            HttpResponseMessage response = this.Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(result), System.Text.Encoding.UTF8, "application/json");
            return response;
        }


        /// <summary> 
        ///     藥劑狀態統計
        /// </summary>
        /// <returns></returns> 
        /// <remarks> </remarks>
        [Route("DisinfectantStateTable")]
        [HttpGet]
        [SwaggerResponse(HttpStatusCode.OK, "成功", typeof(DisinfectantStateTableCount))]
        public HttpResponseMessage DisinfectantStateTable()
        {
            List<DisinfectantStateTableCount> result = (db.Disinfectant.GroupBy(d => d.City)
                                  .Select(g => new DisinfectantStateTableCount()
                                  {
                                      City = g.Key,
                                      Solid = g.Where(v => v.DrugState == "固體" && v.Amount.HasValue).Count() == 0 ? 0 : g.Where(v => v.DrugState == "固體" && v.Amount.HasValue).Sum(v => v.Amount.Value),
                                      Liquid = g.Where(v => v.DrugState == "液體" && v.Amount.HasValue).Count() == 0 ? 0 : g.Where(v => v.DrugState == "液體" && v.Amount.HasValue).Sum(v => v.Amount.Value),
                                      Emulsion = g.Where(v => v.DrugState == "乳劑" && v.Amount.HasValue).Count() == 0 ? 0 : g.Where(v => v.DrugState == "乳劑" && v.Amount.HasValue).Sum(v => v.Amount.Value),
                                      Oil = g.Where(v => v.DrugState == "油劑" && v.Amount.HasValue).Count() == 0 ? 0 : g.Where(v => v.DrugState == "油劑" && v.Amount.HasValue).Sum(v => v.Amount.Value),
                                     })).ToList();



            DisinfectantStateTableCount ALLresult = new DisinfectantStateTableCount
            {
                City = "Taiwan",               
                Solid = db.Disinfectant.Where(v => v.DrugState == "固體" && v.Amount.HasValue).Count() == 0 ? 0 : db.Disinfectant.Where(v => v.DrugState == "固體" && v.Amount.HasValue).Sum(v => v.Amount.Value),
                Liquid = db.Disinfectant.Where(v => v.DrugState == "液體" && v.Amount.HasValue).Count() == 0 ? 0 : db.Disinfectant.Where(v => v.DrugState == "液體" && v.Amount.HasValue).Sum(v => v.Amount.Value),
                Emulsion = db.Disinfectant.Where(v => v.DrugState == "乳劑" && v.Amount.HasValue).Count() == 0 ? 0 : db.Disinfectant.Where(v => v.DrugState == "乳劑" && v.Amount.HasValue).Sum(v => v.Amount.Value),
                Oil = db.Disinfectant.Where(v => v.DrugState == "油劑" && v.Amount.HasValue).Count() == 0 ? 0 : db.Disinfectant.Where(v => v.DrugState == "油劑" && v.Amount.HasValue).Sum(v => v.Amount.Value),
            };


            result.Add(ALLresult);

            HttpResponseMessage response = this.Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(result), System.Text.Encoding.UTF8, "application/json");
            return response;
        }


        /// <summary> 
        ///     人員基本資料
        /// </summary>
        /// <returns></returns> 
        /// <remarks> </remarks>
        [Route("ContactAccount")]
        [HttpPost]
        [SwaggerResponse(HttpStatusCode.OK, "成功", typeof(USER))]
        public HttpResponseMessage ContactAccount([FromBody] login User)
        {
            var token = Request.Headers.Where(X=>X.Key=="token").FirstOrDefault().Value.FirstOrDefault();
            if (token == "aS6bQK2Bj4rS[awqFY&")
            {
                List<USER> result = (from a in db.Users
                                     where a.UserName == User.UserName && a.Pwd == User.Pwd && (a.DutyId == 2 || a.DutyId == 3 || a.DutyId == 5 || a.DutyId == 6)
                                     select new USER()
                                     {
                                         CityId = a.CityId,
                                         Email = a.Email,
                                         Id = a.Id,
                                         MobilePhone = a.MobilePhone,
                                         Name = a.Name,
                                         OfficePhone = a.OfficePhone,

                                     }).ToList();
                if (result.Count() == 0)
                {
                    HttpResponseMessage response = this.Request.CreateResponse(HttpStatusCode.OK);
                    response.Content = new StringContent("登入失敗，請聯繫環境災害管理資訊系統客服", System.Text.Encoding.UTF8);
                    return response;
                }
                else if (result.Count() > 1)
                {
                    HttpResponseMessage response = this.Request.CreateResponse(HttpStatusCode.OK);
                    response.Content = new StringContent("帳號資料異常，請聯繫環境災害管理資訊系統客服", System.Text.Encoding.UTF8);
                    return response;
                }
                else
                {
                    HttpResponseMessage response = this.Request.CreateResponse(HttpStatusCode.OK);
                    response.Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(result), System.Text.Encoding.UTF8, "application/json");
                    return response;
                }
               
            }
            else
            {
                HttpResponseMessage response = this.Request.CreateResponse(HttpStatusCode.Forbidden);
                return response;
            }
        }















        /// <summary> 
        ///     縣市
        /// </summary>
        /// <returns></returns> 
        /// <remarks> </remarks>
        [Route("CITY")]
        [HttpGet]
        [SwaggerResponse(HttpStatusCode.OK, "成功", typeof(City))]
        public HttpResponseMessage CITY(string IsCounty = "1")
        {
            HttpResponseMessage response = this.Request.CreateResponse(HttpStatusCode.OK);
            if (IsCounty == "1")
            {
                var result = db.City.Where(X => X.IsCounty == true);                
                response.Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(result), System.Text.Encoding.UTF8, "application/json");
            }
            else
            {
                var result = db.City;              
                response.Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(result), System.Text.Encoding.UTF8, "application/json");
            }
           

            return response;
        }






        /// <summary> 
        ///     車輛類別
        /// </summary>
        /// <returns></returns> 
        /// <remarks> </remarks>
        [Route("VehicleType")]
        [HttpGet]
        [SwaggerResponse(HttpStatusCode.OK, "成功", typeof(VehicleType))]
        public HttpResponseMessage VehicleType()
        {
            var result = db.VehicleType;
            HttpResponseMessage response = this.Request.CreateResponse(HttpStatusCode.OK);
           
                response.Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(result), System.Text.Encoding.UTF8, "application/json");
           
            return response;
        }





        /// <summary> 
        ///     設備類別
        /// </summary>
        /// <returns></returns> 
        /// <remarks> </remarks>
        [Route("Equipment")]
        [HttpGet]
        [SwaggerResponse(HttpStatusCode.OK, "成功", typeof(List<string>))]
        public HttpResponseMessage Equipment()
        {
          
            List<string> result  = new List<string> 
        {
            "車載式高壓噴霧機",
            "高壓噴霧機",
            "超低容量噴霧機",
            "車載式煙霧機",
            "高壓清洗機",
            "噴霧機",
            "消毒機(器)",
            "熱煙霧機",
            "高壓清洗機",
            "其他"
        };

            HttpResponseMessage response = this.Request.CreateResponse(HttpStatusCode.OK);

            response.Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(result), System.Text.Encoding.UTF8, "application/json");

            return response;
        }




        /// <summary> 
        ///     藥劑狀態
        /// </summary>
        /// <returns></returns> 
        /// <remarks> </remarks>
        [Route("PotionStatus")]
        [HttpGet]
        [SwaggerResponse(HttpStatusCode.OK, "成功", typeof(List<string>))]
        public HttpResponseMessage PotionStatus()
        {

            List<string> result = new List<string>
        {
            "固體",
            "液體",
            "乳劑",
            "油劑"
        };

            HttpResponseMessage response = this.Request.CreateResponse(HttpStatusCode.OK);

            response.Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(result), System.Text.Encoding.UTF8, "application/json");

            return response;
        }








        /// <summary> 
        ///     藥劑用途
        /// </summary>
        /// <returns></returns> 
        /// <remarks> </remarks>
        [Route("PharmaceuticalUse")]
        [HttpGet]
        [SwaggerResponse(HttpStatusCode.OK, "成功", typeof(List<string>))]
        public HttpResponseMessage PharmaceuticalUse()
        {

            List<string> result = new List<string>
        {
            "環境消毒",
            "登革熱",
            "紅火蟻",
            "荔枝椿象",
            "其他"
        };

            HttpResponseMessage response = this.Request.CreateResponse(HttpStatusCode.OK);

            response.Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(result), System.Text.Encoding.UTF8, "application/json");

            return response;
        }

        /// <summary> 
        ///     設備用途
        /// </summary>
        /// <returns></returns> 
        /// <remarks> </remarks>
        [Route("EquipmentUse")]
        [HttpGet]
        [SwaggerResponse(HttpStatusCode.OK, "成功", typeof(List<string>))]
        public HttpResponseMessage EquipmentUse()
        {

            List<string> result = new List<string>
        {
            "環境消毒",
            "登革熱",
            "共用",           
            "其他"
        };

            HttpResponseMessage response = this.Request.CreateResponse(HttpStatusCode.OK);

            response.Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(result), System.Text.Encoding.UTF8, "application/json");

            return response;
        }








    }




    public class vehicleCount
    {
      
        public string City { get; set; }
        public int ALL { get; set; }
        public int USE { get; set; }
        public int NOTUSE { get; set; }


    }

    public class DisinfectorCount
    {

        public string City { get; set; }
        public int? ALL { get; set; }
        public int? dengue { get; set; }
        public int? share { get; set; }

        public int? other { get; set; }
        public int? disinfection { get; set; }



    }


    public class DisinfectantCount
    {

        public string City { get; set; }
        public decimal? ALL { get; set; }
        public decimal? dengue { get; set; }
        public decimal? Fir_ants { get; set; }

        public decimal? other { get; set; }
        public decimal? disinfection { get; set; }
        public decimal? Tessaratoma_papillosa { get; set; }
      
    }



    public class DisinfectantStateTableCount
    {
       
        public string City { get; set; }
        public decimal Solid { get; set; }
        public decimal Liquid { get; set; }
        public decimal Emulsion { get; set; }
        public decimal Oil { get; set; }

    }



    public class USER
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int? CityId { get; set; }
        public string MobilePhone { get; set; }
        public string OfficePhone { get; set; }
        public string Email { get; set; }

    }


    public class login
    {

        public string UserName { get; set; }

        public string Pwd { get; set; }


    }






    public class OPEN
    {
        public int ID { get; set; }
        public double? xx { get; set; }
        public double? yy { get; set; }
        public string City { get; set; }
        public string TOWN { get; set; }
        public string OPName { get; set; }
        public string Name { get; set; }
        public string Fac { get; set; }
        public string Owner { get; set; }
        public string TEL { get; set; }
        public string MobileTEL { get; set; }
        public DateTime OContractDateEnd { get; set; }
        public List<Contract> contract { get; set; }

    }

    public class Contract
    {

        public string Items { get; set; }
        public string Unit { get; set; }
        public string Count { get; set; }
        public string Price { get; set; }
        public decimal Budge { get; set; }

    }







    public class BASIC_DATA_VIEW
    {

        public string ADMIT { get; set; }
        public string COUNTY_NAME { get; set; }

        public double? xx { get; set; }
        public double? yy { get; set; }




    }




    public class Data
    {

        public string City { get; set; }


        public string Town { get; set; }


        public double? xx { get; set; }


        public double? yy { get; set; }


        public int? Vehicle { get; set; }


        public int? Disinfector { get; set; }

        public decimal? SolidDrugStateDisinfectant { get; set; }

  
        public decimal? LiquidDrugStateDisinfectant { get; set; }


        public int? Toilet { get; set; }
    }
}
