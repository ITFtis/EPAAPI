using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EPAAPI.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<ApplyCarHandlingSituation> ApplyCarHandlingSituation { get; set; }
        public virtual DbSet<ApplyDisinfectionEquipmentHandlingSituation> ApplyDisinfectionEquipmentHandlingSituation { get; set; }
        public virtual DbSet<ApplyHandlingSituation> ApplyHandlingSituation { get; set; }
        public virtual DbSet<ApplyMedicineHandlingSituation> ApplyMedicineHandlingSituation { get; set; }
        public virtual DbSet<ApplyOtherSubsidy> ApplyOtherSubsidy { get; set; }
        public virtual DbSet<ApplyPeopleHandlingSituation> ApplyPeopleHandlingSituation { get; set; }
        public virtual DbSet<ApplySubsidy> ApplySubsidy { get; set; }
        public virtual DbSet<ApplySubsidyDetail> ApplySubsidyDetail { get; set; }
        public virtual DbSet<BASIC_DATA> BASIC_DATA { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Contactmanual> Contactmanual { get; set; }
        public virtual DbSet<ContactManual_> ContactManual_ { get; set; }
        public virtual DbSet<ContactManualDate> ContactManualDate { get; set; }
        public virtual DbSet<ContactManualDepartment> ContactManualDepartment { get; set; }
        public virtual DbSet<ContactManualDepartment20221222> ContactManualDepartment20221222 { get; set; }
        public virtual DbSet<ContactManualDownloadRecord> ContactManualDownloadRecord { get; set; }
        public virtual DbSet<ContactManualRole> ContactManualRole { get; set; }
        public virtual DbSet<ContactManualRole20221221> ContactManualRole20221221 { get; set; }
        public virtual DbSet<ContactManualSupervise> ContactManualSupervise { get; set; }
        public virtual DbSet<ContactManulTYpe> ContactManulTYpe { get; set; }
        public virtual DbSet<ContactManulTYpe20221222> ContactManulTYpe20221222 { get; set; }
        public virtual DbSet<Damage> Damage { get; set; }
        public virtual DbSet<DamageMain> DamageMain { get; set; }
        public virtual DbSet<ddi_all_> ddi_all_ { get; set; }
        public virtual DbSet<ddt_> ddt_ { get; set; }
        public virtual DbSet<Defend> Defend { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Diaster> Diaster { get; set; }
        public virtual DbSet<Diaster_BAK> Diaster_BAK { get; set; }
        public virtual DbSet<Disinfectant> Disinfectant { get; set; }
        public virtual DbSet<Disinfector> Disinfector { get; set; }
        public virtual DbSet<FileUpload> FileUpload { get; set; }
        public virtual DbSet<FileUploadLevel> FileUploadLevel { get; set; }
        public virtual DbSet<InfectiousDisease> InfectiousDisease { get; set; }
        public virtual DbSet<Polymer> Polymer { get; set; }
        public virtual DbSet<PolymerDetail> PolymerDetail { get; set; }
        public virtual DbSet<Position> Position { get; set; }
        public virtual DbSet<SendTextLog> SendTextLog { get; set; }
        public virtual DbSet<SendTextLogDetail> SendTextLogDetail { get; set; }
        public virtual DbSet<TaskWork> TaskWork { get; set; }
        public virtual DbSet<TaskWork_1> TaskWork_1 { get; set; }
        public virtual DbSet<Text> Text { get; set; }
        public virtual DbSet<Town> Town { get; set; }
        public virtual DbSet<UserArea> UserArea { get; set; }
        public virtual DbSet<UserGroup> UserGroup { get; set; }
        public virtual DbSet<UserGroupMapp> UserGroupMapp { get; set; }
        public virtual DbSet<UserLoginLog> UserLoginLog { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Users_> Users_ { get; set; }
        public virtual DbSet<UsersNew> UsersNew { get; set; }
        public virtual DbSet<VehicleType> VehicleType { get; set; }
        public virtual DbSet<ApplyCar> ApplyCar { get; set; }
        public virtual DbSet<ApplyCarDetail> ApplyCarDetail { get; set; }
        public virtual DbSet<ApplyCarType> ApplyCarType { get; set; }
        public virtual DbSet<ApplyDisinfectionEquipment> ApplyDisinfectionEquipment { get; set; }
        public virtual DbSet<ApplyDisinfectionEquipmentDetail> ApplyDisinfectionEquipmentDetail { get; set; }
        public virtual DbSet<ApplyDrug> ApplyDrug { get; set; }
        public virtual DbSet<ApplyMedicine> ApplyMedicine { get; set; }
        public virtual DbSet<ApplyMedicineDetail> ApplyMedicineDetail { get; set; }
        public virtual DbSet<ApplyOther> ApplyOther { get; set; }
        public virtual DbSet<ApplyOtherDetail> ApplyOtherDetail { get; set; }
        public virtual DbSet<ApplyPeople> ApplyPeople { get; set; }
        public virtual DbSet<ApplySubsidyType> ApplySubsidyType { get; set; }
        public virtual DbSet<ApplySubsidyTypeDetail> ApplySubsidyTypeDetail { get; set; }
        public virtual DbSet<Area> Area { get; set; }
        public virtual DbSet<CAR_EQUIP> CAR_EQUIP { get; set; }
        public virtual DbSet<ConfirmTime> ConfirmTime { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<ContactManualOld_> ContactManualOld_ { get; set; }
        public virtual DbSet<ContactManualRole_> ContactManualRole_ { get; set; }
        public virtual DbSet<ContactManualRoleBak> ContactManualRoleBak { get; set; }
        public virtual DbSet<ddi_> ddi_ { get; set; }
        public virtual DbSet<ddibak> ddibak { get; set; }
        public virtual DbSet<ddt> ddt { get; set; }
        public virtual DbSet<ddtbak> ddtbak { get; set; }
        public virtual DbSet<DefendDutyQuestion> DefendDutyQuestion { get; set; }
        public virtual DbSet<DefendQuestion> DefendQuestion { get; set; }
        public virtual DbSet<DefendQuestion_bak> DefendQuestion_bak { get; set; }
        public virtual DbSet<Department20221222> Department20221222 { get; set; }
        public virtual DbSet<Disinfectant_1110> Disinfectant_1110 { get; set; }
        public virtual DbSet<Disinfectorbak> Disinfectorbak { get; set; }
        public virtual DbSet<District> District { get; set; }
        public virtual DbSet<District_bak> District_bak { get; set; }
        public virtual DbSet<DRINK_DETAIL> DRINK_DETAIL { get; set; }
        public virtual DbSet<DRINK_NO> DRINK_NO { get; set; }
        public virtual DbSet<DRINK_SECOND> DRINK_SECOND { get; set; }
        public virtual DbSet<Dump> Dump { get; set; }
        public virtual DbSet<Duty> Duty { get; set; }
        public virtual DbSet<Emis> Emis { get; set; }
        public virtual DbSet<FileData> FileData { get; set; }
        public virtual DbSet<GIS_dwdftwell> GIS_dwdftwell { get; set; }
        public virtual DbSet<GIS_dwintake> GIS_dwintake { get; set; }
        public virtual DbSet<GIS_dwswtf> GIS_dwswtf { get; set; }
        public virtual DbSet<GIS_dwwtp> GIS_dwwtp { get; set; }
        public virtual DbSet<GIS_eetown> GIS_eetown { get; set; }
        public virtual DbSet<Incinerator> Incinerator { get; set; }
        public virtual DbSet<Incinerator_OLD> Incinerator_OLD { get; set; }
        public virtual DbSet<Landfill> Landfill { get; set; }
        public virtual DbSet<Landfill_OLD> Landfill_OLD { get; set; }
        public virtual DbSet<Mail> Mail { get; set; }
        public virtual DbSet<MainShiftSchedule> MainShiftSchedule { get; set; }
        public virtual DbSet<MainShiftScheduleUser> MainShiftScheduleUser { get; set; }
        public virtual DbSet<Meeting_Sign> Meeting_Sign { get; set; }
        public virtual DbSet<Meeting_Sign_Detail> Meeting_Sign_Detail { get; set; }
        public virtual DbSet<MutualSupport> MutualSupport { get; set; }
        public virtual DbSet<NewestCountValue> NewestCountValue { get; set; }
        public virtual DbSet<NewestUpdateTime> NewestUpdateTime { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Notice> Notice { get; set; }
        public virtual DbSet<OpenContract> OpenContract { get; set; }
        public virtual DbSet<OpenContractDetail> OpenContractDetail { get; set; }
        public virtual DbSet<OpenContractDetailItemCategory> OpenContractDetailItemCategory { get; set; }
        public virtual DbSet<Pest> Pest { get; set; }
        public virtual DbSet<PhoneWork> PhoneWork { get; set; }
        public virtual DbSet<PhoneWork_1> PhoneWork_1 { get; set; }
        public virtual DbSet<Position20221223> Position20221223 { get; set; }
        public virtual DbSet<Question> Question { get; set; }
        public virtual DbSet<Registers> Registers { get; set; }
        public virtual DbSet<ResourceType> ResourceType { get; set; }
        public virtual DbSet<ShiftSchedule> ShiftSchedule { get; set; }
        public virtual DbSet<ShiftScheduleUser> ShiftScheduleUser { get; set; }
        public virtual DbSet<SUP_CAR> SUP_CAR { get; set; }
        public virtual DbSet<SUP_CAR_LIST> SUP_CAR_LIST { get; set; }
        public virtual DbSet<SUP_Check_List> SUP_Check_List { get; set; }
        public virtual DbSet<SUP_DRUG> SUP_DRUG { get; set; }
        public virtual DbSet<SUP_DRUG_LIST> SUP_DRUG_LIST { get; set; }
        public virtual DbSet<SUP_EQUIP> SUP_EQUIP { get; set; }
        public virtual DbSet<SUP_EQUIP_LIST> SUP_EQUIP_LIST { get; set; }
        public virtual DbSet<SUP_MAN> SUP_MAN { get; set; }
        public virtual DbSet<SUP_MONEY> SUP_MONEY { get; set; }
        public virtual DbSet<SUP_MONEY_LIST_EPA> SUP_MONEY_LIST_EPA { get; set; }
        public virtual DbSet<SUP_MONEY_LIST_EQ> SUP_MONEY_LIST_EQ { get; set; }
        public virtual DbSet<SUP_MONEY_LIST_ME> SUP_MONEY_LIST_ME { get; set; }
        public virtual DbSet<SUP_MONEY_LIST_MI> SUP_MONEY_LIST_MI { get; set; }
        public virtual DbSet<SUP_MONEY_LIST_OT> SUP_MONEY_LIST_OT { get; set; }
        public virtual DbSet<SUP_MONEY_LIST_TO> SUP_MONEY_LIST_TO { get; set; }
        public virtual DbSet<SUP_MONEY_LIST_WO> SUP_MONEY_LIST_WO { get; set; }
        public virtual DbSet<SUP_OTHER> SUP_OTHER { get; set; }
        public virtual DbSet<SUP_OTHER_LIST> SUP_OTHER_LIST { get; set; }
        public virtual DbSet<SUPPORT_CASH> SUPPORT_CASH { get; set; }
        public virtual DbSet<SUPPORT_HISTORY> SUPPORT_HISTORY { get; set; }
        public virtual DbSet<SUPPORT_MAIN> SUPPORT_MAIN { get; set; }
        public virtual DbSet<SUPPORT_MAIN_BK> SUPPORT_MAIN_BK { get; set; }
        public virtual DbSet<SystemConfigSetting> SystemConfigSetting { get; set; }
        public virtual DbSet<TeamShiftSchedule> TeamShiftSchedule { get; set; }
        public virtual DbSet<TeamShiftScheduleUser> TeamShiftScheduleUser { get; set; }
        public virtual DbSet<Toilet> Toilet { get; set; }
        public virtual DbSet<ToiletCleaningLog> ToiletCleaningLog { get; set; }
        public virtual DbSet<ToiletLocation> ToiletLocation { get; set; }
        public virtual DbSet<TRASH_BURN> TRASH_BURN { get; set; }
        public virtual DbSet<TRASH_BURY> TRASH_BURY { get; set; }
        public virtual DbSet<TREATMENT> TREATMENT { get; set; }
        public virtual DbSet<USER_DATA> USER_DATA { get; set; }
        public virtual DbSet<USER_LEV> USER_LEV { get; set; }
        public virtual DbSet<USER_SELECT_LIST> USER_SELECT_LIST { get; set; }
        public virtual DbSet<Users___old> Users___old { get; set; }
        public virtual DbSet<Users_problem> Users_problem { get; set; }
        public virtual DbSet<Usersbak> Usersbak { get; set; }
        public virtual DbSet<Usersbak_Important> Usersbak_Important { get; set; }
        public virtual DbSet<Usersbak_Important_bak_> Usersbak_Important_bak_ { get; set; }
        public virtual DbSet<Vehicle> Vehicle { get; set; }
        public virtual DbSet<Vehicle_0822> Vehicle_0822 { get; set; }
        public virtual DbSet<Vehicle_0902> Vehicle_0902 { get; set; }
        public virtual DbSet<Vehicle_1014> Vehicle_1014 { get; set; }
        public virtual DbSet<Vehicle_1100208> Vehicle_1100208 { get; set; }
        public virtual DbSet<Vehicle_1100503> Vehicle_1100503 { get; set; }
        public virtual DbSet<Vehicle_bak> Vehicle_bak { get; set; }
        public virtual DbSet<Vehicle_Insert> Vehicle_Insert { get; set; }
        public virtual DbSet<Vehicle_OtherReady> Vehicle_OtherReady { get; set; }
        public virtual DbSet<VihicleAdd_> VihicleAdd_ { get; set; }
        public virtual DbSet<Volunteer> Volunteer { get; set; }
        public virtual DbSet<vvtbak> vvtbak { get; set; }
        public virtual DbSet<vvv> vvv { get; set; }
        public virtual DbSet<Water_Equipment> Water_Equipment { get; set; }
        public virtual DbSet<WaterCheck> WaterCheck { get; set; }
        public virtual DbSet<WaterCheckDetail> WaterCheckDetail { get; set; }
        public virtual DbSet<WaterDivision> WaterDivision { get; set; }
        public virtual DbSet<WaterEquipment> WaterEquipment { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplyCarHandlingSituation>()
                .Property(e => e.Subsidy)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ApplyDisinfectionEquipmentHandlingSituation>()
                .Property(e => e.Subsidy)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ApplyHandlingSituation>()
                .Property(e => e.Subsidy)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ApplyMedicineHandlingSituation>()
                .Property(e => e.Subsidy)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ApplyPeopleHandlingSituation>()
                .Property(e => e.Subsidy)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ApplySubsidyDetail>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Damage>()
                .Property(e => e.DamageArea)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Damage>()
                .Property(e => e.FloodArea)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Damage>()
                .Property(e => e.DisinfectArea)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Damage>()
                .Property(e => e.PR_Garbage)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Damage>()
                .Property(e => e.CLE_Disinfect)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Damage>()
                .Property(e => e.CLE_MUD)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Damage>()
                .Property(e => e.CLE_Trash)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Damage>()
                .Property(e => e.CLE_Garbage)
                .HasPrecision(18, 3);

            modelBuilder.Entity<ddi_all_>()
                .Property(e => e.Density)
                .IsUnicode(false);

            modelBuilder.Entity<ddt_>()
                .Property(e => e.ROCyear)
                .IsUnicode(false);

            modelBuilder.Entity<Diaster>()
                .Property(e => e.CoverCity)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Diaster_BAK>()
                .Property(e => e.CoverCity)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Disinfectant>()
                .Property(e => e.Density)
                .IsUnicode(false);

            modelBuilder.Entity<Disinfector>()
                .Property(e => e.ROCyear)
                .IsUnicode(false);

            modelBuilder.Entity<InfectiousDisease>()
                .Property(e => e.HomeQuarantineGarbageAmount)
                .HasPrecision(18, 3);

            modelBuilder.Entity<InfectiousDisease>()
                .Property(e => e.HomeInspectionGarbageAmount)
                .HasPrecision(18, 3);

            modelBuilder.Entity<InfectiousDisease>()
                .Property(e => e.InspectionHotelGarbageAmount)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Polymer>()
                .Property(e => e.Amount)
                .HasPrecision(18, 3);

            modelBuilder.Entity<PolymerDetail>()
                .Property(e => e.UseAmount)
                .HasPrecision(18, 3);

            modelBuilder.Entity<PolymerDetail>()
                .Property(e => e.WaterAmount)
                .HasPrecision(18, 3);

            modelBuilder.Entity<PolymerDetail>()
                .Property(e => e.DrugAmount)
                .HasPrecision(18, 3);

            modelBuilder.Entity<PolymerDetail>()
                .Property(e => e.Turbidity)
                .HasPrecision(18, 3);

            modelBuilder.Entity<PolymerDetail>()
                .Property(e => e.Inventory)
                .HasPrecision(18, 3);

            modelBuilder.Entity<PolymerDetail>()
                .Property(e => e.OriginalInventory)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Position>()
                .Property(e => e.CreateUser)
                .IsFixedLength();

            modelBuilder.Entity<Position>()
                .Property(e => e.UpdateUser)
                .IsFixedLength();

            modelBuilder.Entity<ApplyCarType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ApplySubsidyType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ApplySubsidyTypeDetail>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<CAR_EQUIP>()
                .Property(e => e.CarNow)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ddi_>()
                .Property(e => e.Density)
                .IsUnicode(false);

            modelBuilder.Entity<ddibak>()
                .Property(e => e.Density)
                .IsUnicode(false);

            modelBuilder.Entity<ddt>()
                .Property(e => e.ROCyear)
                .IsUnicode(false);

            modelBuilder.Entity<ddtbak>()
                .Property(e => e.ROCyear)
                .IsUnicode(false);

            modelBuilder.Entity<Disinfectant_1110>()
                .Property(e => e.Density)
                .IsUnicode(false);

            modelBuilder.Entity<Disinfectorbak>()
                .Property(e => e.ROCyear)
                .IsUnicode(false);

            modelBuilder.Entity<District>()
                .Property(e => e.Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<District>()
                .Property(e => e.CoverArea)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<District>()
                .Property(e => e.Service)
                .IsUnicode(false);

            modelBuilder.Entity<District>()
                .Property(e => e.Human)
                .IsUnicode(false);

            modelBuilder.Entity<District>()
                .Property(e => e.OutHuman)
                .IsUnicode(false);

            modelBuilder.Entity<District>()
                .Property(e => e.ReadyHuman)
                .IsUnicode(false);

            modelBuilder.Entity<District>()
                .Property(e => e.CleanCapacity)
                .IsUnicode(false);

            modelBuilder.Entity<District_bak>()
                .Property(e => e.Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<District_bak>()
                .Property(e => e.CoverArea)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<District_bak>()
                .Property(e => e.Service)
                .IsUnicode(false);

            modelBuilder.Entity<District_bak>()
                .Property(e => e.Human)
                .IsUnicode(false);

            modelBuilder.Entity<District_bak>()
                .Property(e => e.OutHuman)
                .IsUnicode(false);

            modelBuilder.Entity<District_bak>()
                .Property(e => e.ReadyHuman)
                .IsUnicode(false);

            modelBuilder.Entity<District_bak>()
                .Property(e => e.CleanCapacity)
                .IsUnicode(false);

            modelBuilder.Entity<Dump>()
                .Property(e => e.Xpos)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Dump>()
                .Property(e => e.Ypos)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Dump>()
                .Property(e => e.Area)
                .IsUnicode(false);

            modelBuilder.Entity<Dump>()
                .Property(e => e.EmergencyMobilePhone)
                .IsUnicode(false);

            modelBuilder.Entity<Dump>()
                .Property(e => e.EmergencyPhoneDay)
                .IsUnicode(false);

            modelBuilder.Entity<Dump>()
                .Property(e => e.EmergencyPhoneNight)
                .IsUnicode(false);

            modelBuilder.Entity<Emis>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Emis>()
                .Property(e => e.VoicePwd)
                .IsUnicode(false);

            modelBuilder.Entity<Incinerator>()
                .Property(e => e.Xpos)
                .HasPrecision(18, 15);

            modelBuilder.Entity<Incinerator>()
                .Property(e => e.Ypos)
                .HasPrecision(18, 15);

            modelBuilder.Entity<Incinerator_OLD>()
                .Property(e => e.Xpos)
                .HasPrecision(18, 15);

            modelBuilder.Entity<Incinerator_OLD>()
                .Property(e => e.Ypos)
                .HasPrecision(18, 15);

            modelBuilder.Entity<Landfill>()
                .Property(e => e.Xpos)
                .HasPrecision(18, 15);

            modelBuilder.Entity<Landfill>()
                .Property(e => e.Ypos)
                .HasPrecision(18, 15);

            modelBuilder.Entity<Landfill>()
                .Property(e => e.DesignCapacity)
                .IsUnicode(false);

            modelBuilder.Entity<Landfill>()
                .Property(e => e.ResidualCapacity)
                .IsUnicode(false);

            modelBuilder.Entity<Landfill_OLD>()
                .Property(e => e.Xpos)
                .HasPrecision(18, 15);

            modelBuilder.Entity<Landfill_OLD>()
                .Property(e => e.Ypos)
                .HasPrecision(18, 15);

            modelBuilder.Entity<Landfill_OLD>()
                .Property(e => e.DesignCapacity)
                .IsUnicode(false);

            modelBuilder.Entity<Landfill_OLD>()
                .Property(e => e.ResidualCapacity)
                .IsUnicode(false);

            modelBuilder.Entity<Mail>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Meeting_Sign>()
                .Property(e => e.Meeting_Keyin_name)
                .IsFixedLength();

            modelBuilder.Entity<Meeting_Sign>()
                .Property(e => e.del)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NewestCountValue>()
                .Property(e => e.Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NewestUpdateTime>()
                .Property(e => e.Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Pest>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Pest>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<Pest>()
                .Property(e => e.License)
                .IsUnicode(false);

            modelBuilder.Entity<Position20221223>()
                .Property(e => e.CreateUser)
                .IsFixedLength();

            modelBuilder.Entity<Position20221223>()
                .Property(e => e.UpdateUser)
                .IsFixedLength();

            modelBuilder.Entity<Registers>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<SUP_DRUG>()
                .Property(e => e.NUM1)
                .IsUnicode(false);

            modelBuilder.Entity<SUP_DRUG>()
                .Property(e => e.NUM2)
                .IsUnicode(false);

            modelBuilder.Entity<SUP_DRUG_LIST>()
                .Property(e => e.C_NUM)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Toilet>()
                .Property(e => e.SlotNumber)
                .IsUnicode(false);

            modelBuilder.Entity<ToiletLocation>()
                .Property(e => e.Xpos)
                .HasPrecision(18, 15);

            modelBuilder.Entity<ToiletLocation>()
                .Property(e => e.Ypos)
                .HasPrecision(18, 15);

            modelBuilder.Entity<USER_DATA>()
                .Property(e => e.IS_Manage)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<USER_DATA>()
                .Property(e => e.CTI_PWD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.CrossTownUse)
                .IsFixedLength();

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.Xpos)
                .HasPrecision(38, 19);

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.Ypos)
                .HasPrecision(38, 19);

            modelBuilder.Entity<Vehicle_0822>()
                .Property(e => e.CrossTownUse)
                .IsFixedLength();

            modelBuilder.Entity<Vehicle_0822>()
                .Property(e => e.Xpos)
                .HasPrecision(38, 19);

            modelBuilder.Entity<Vehicle_0822>()
                .Property(e => e.Ypos)
                .HasPrecision(38, 19);

            modelBuilder.Entity<Vehicle_0902>()
                .Property(e => e.CrossTownUse)
                .IsFixedLength();

            modelBuilder.Entity<Vehicle_0902>()
                .Property(e => e.Xpos)
                .HasPrecision(38, 19);

            modelBuilder.Entity<Vehicle_0902>()
                .Property(e => e.Ypos)
                .HasPrecision(38, 19);

            modelBuilder.Entity<Vehicle_1014>()
                .Property(e => e.CrossTownUse)
                .IsFixedLength();

            modelBuilder.Entity<Vehicle_1014>()
                .Property(e => e.Xpos)
                .HasPrecision(38, 19);

            modelBuilder.Entity<Vehicle_1014>()
                .Property(e => e.Ypos)
                .HasPrecision(38, 19);

            modelBuilder.Entity<Vehicle_1100208>()
                .Property(e => e.CrossTownUse)
                .IsFixedLength();

            modelBuilder.Entity<Vehicle_1100208>()
                .Property(e => e.Xpos)
                .HasPrecision(38, 19);

            modelBuilder.Entity<Vehicle_1100208>()
                .Property(e => e.Ypos)
                .HasPrecision(38, 19);

            modelBuilder.Entity<Vehicle_1100503>()
                .Property(e => e.CrossTownUse)
                .IsFixedLength();

            modelBuilder.Entity<Vehicle_1100503>()
                .Property(e => e.Xpos)
                .HasPrecision(38, 19);

            modelBuilder.Entity<Vehicle_1100503>()
                .Property(e => e.Ypos)
                .HasPrecision(38, 19);

            modelBuilder.Entity<Vehicle_bak>()
                .Property(e => e.CrossTownUse)
                .IsFixedLength();

            modelBuilder.Entity<Vehicle_bak>()
                .Property(e => e.Xpos)
                .HasPrecision(38, 19);

            modelBuilder.Entity<Vehicle_bak>()
                .Property(e => e.Ypos)
                .HasPrecision(38, 19);

            modelBuilder.Entity<Vehicle_Insert>()
                .Property(e => e.CrossTownUse)
                .IsFixedLength();

            modelBuilder.Entity<Vehicle_Insert>()
                .Property(e => e.Xpos)
                .HasPrecision(38, 19);

            modelBuilder.Entity<Vehicle_Insert>()
                .Property(e => e.Ypos)
                .HasPrecision(38, 19);

            modelBuilder.Entity<Vehicle_OtherReady>()
                .Property(e => e.CrossTownUse)
                .IsFixedLength();

            modelBuilder.Entity<Vehicle_OtherReady>()
                .Property(e => e.Xpos)
                .HasPrecision(38, 19);

            modelBuilder.Entity<Vehicle_OtherReady>()
                .Property(e => e.Ypos)
                .HasPrecision(38, 19);

            modelBuilder.Entity<VihicleAdd_>()
                .Property(e => e.Xpos)
                .HasPrecision(38, 19);

            modelBuilder.Entity<VihicleAdd_>()
                .Property(e => e.Ypos)
                .HasPrecision(38, 19);

            modelBuilder.Entity<vvtbak>()
                .Property(e => e.ROCyear)
                .IsUnicode(false);

            modelBuilder.Entity<vvv>()
                .Property(e => e.CrossTownUse)
                .IsFixedLength();

            modelBuilder.Entity<vvv>()
                .Property(e => e.Xpos)
                .HasPrecision(38, 19);

            modelBuilder.Entity<vvv>()
                .Property(e => e.Ypos)
                .HasPrecision(38, 19);

            modelBuilder.Entity<Water_Equipment>()
                .Property(e => e.NormalAmount)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Water_Equipment>()
                .Property(e => e.AbnormalAmount)
                .HasPrecision(18, 3);

            modelBuilder.Entity<WaterCheckDetail>()
                .Property(e => e.O_Turbidity)
                .HasPrecision(18, 3);

            modelBuilder.Entity<WaterCheckDetail>()
                .Property(e => e.Chlorine)
                .HasPrecision(18, 3);

            modelBuilder.Entity<WaterCheckDetail>()
                .Property(e => e.EColi)
                .HasPrecision(18, 3);

            modelBuilder.Entity<WaterCheckDetail>()
                .Property(e => e.Hydrogen)
                .HasPrecision(18, 3);

            modelBuilder.Entity<WaterCheckDetail>()
                .Property(e => e.Turbidity)
                .HasPrecision(18, 3);

            modelBuilder.Entity<WaterCheckDetail>()
                .Property(e => e.OtherValue)
                .HasPrecision(18, 3);

            modelBuilder.Entity<WaterCheckDetail>()
                .Property(e => e.Other2Value)
                .HasPrecision(18, 3);

            modelBuilder.Entity<WaterCheckDetail>()
                .Property(e => e.Other3Value)
                .HasPrecision(18, 3);

            modelBuilder.Entity<WaterCheckDetail>()
                .Property(e => e.GpsX)
                .HasPrecision(18, 12);

            modelBuilder.Entity<WaterCheckDetail>()
                .Property(e => e.GpsY)
                .HasPrecision(18, 12);

            modelBuilder.Entity<WaterEquipment>()
                .Property(e => e.NormalAmount)
                .HasPrecision(18, 3);

            modelBuilder.Entity<WaterEquipment>()
                .Property(e => e.AbnormalAmount)
                .HasPrecision(18, 3);
        }
    }
}
