namespace opcUaWebMVC;

public abstract class Language
{
    public abstract string LangName { get; set; }

    //Auth Page
    public abstract string AuthPageTitle { get; set; }
    public abstract string AuthPageLabel { get; set; }
    public abstract string AuthPageUsernamePlaceholder { get; set; }
    public abstract string AuthPagePasswordPlaceholder { get; set; }
    public abstract string AuthPageLanguageSelectLabel { get; set; }
    public abstract string AuthPageLoginButton { get; set; }

    //User List Page
    public abstract string UserListTitle { get; set; }
    public abstract string UserListUserTypeAdmin { get; set; }
    public abstract string UserListUserTypeOperator { get; set; }
    public abstract string UserListLabel { get; set; }
    public abstract string UserListAddButton { get; set; }

    //Add User Page
    public abstract string AddUserTitle { get; set; }
    public abstract string AddUserLabel { get; set; }
    public abstract string AddUserNamePlaceholder { get; set; }
    public abstract string AddUserLoginPlaceholder { get; set; }
    public abstract string AddUserPasswordPlaceholder { get; set; }
    public abstract string AddUserIsAdmin { get; set; }
    public abstract string AddUserAddButton { get; set; }

    //Edit User Page
    public abstract string EditUserTitle { get; set; }
    public abstract string EditUserName { get; set; }
    public abstract string EditUserLogin { get; set; }
    public abstract string EditUserNewPassword { get; set; }
    public abstract string EditUserSaveButton { get; set; }
    public abstract string EditUserDeleteUser { get; set; }

    //Plc List Page
    public abstract string PlcListLabel { get; set; }
    public abstract string PlcListNoPlcLabel { get; set; }
    public abstract string PlcListAddButton { get; set; }
    public abstract string PlcListTitle { get; set; }

    //Add PLC page
    public abstract string AddPlcTitle { get; set; }
    public abstract string AddPlcLabel { get; set; }
    public abstract string AddPlcModel { get; set; }
    public abstract string AddPlcTank { get; set; }
    public abstract string AddPlcIp { get; set; }
    public abstract string AddPlcPort { get; set; }
    public abstract string AddPlcAddButton { get; set; }

    //Edit PLC page
    public abstract string EditPlcTitle { get; set; }
    public abstract string EditPlcLabel { get; set; }
    public abstract string EditPlcModel { get; set; }
    public abstract string EditPlcTank { get; set; }
    public abstract string EditPlcIp { get; set; }
    public abstract string EditPlcPort { get; set; }
    public abstract string EditPlcSaveButton { get; set; }
    public abstract string EditPlcDeleteButton { get; set; }

    //Sensors List page
    public abstract string SensorsListTitle { get; set; }
    public abstract string SensorsListLabel { get; set; }
    public abstract string SensorsListNoSensorLabel { get; set; }
    public abstract string SensorListAddButton { get; set; }

    //Add Sensor Page
    public abstract string AddSensorTitle { get; set; }
    public abstract string AddSensorLabel { get; set; }
    public abstract string AddSensorName { get; set; }
    public abstract string AddSensorModel { get; set; }
    public abstract string AddSensorPlc { get; set; }
    public abstract string AddSensorParameter { get; set; }
    public abstract string AddSensorAddButton { get; set; }

    //Parameters List
    public abstract string ParameterListTitle { get; set; }
    public abstract string ParameterListLabel { get; set; }
    public abstract string ParameterListNoLabel { get; set; }
    public abstract string ParameterListAddButton { get; set; }

    //Add parameter page
    public abstract string AddParameterTitle { get; set; }
    public abstract string AddParameterLabel { get; set; }
    public abstract string AddParameterName { get; set; }
    public abstract string AddParameterMinValue { get; set; }
    public abstract string AddParameterMaxValue { get; set; }
    public abstract string AddParameterMinValueOpcTopic { get; set; }
    public abstract string AddParameterMaxValueOpcTopic { get; set; }
    public abstract string AddParameterCurrValueOpcTopic { get; set; }
    public abstract string AddParameterType { get; set; }
    public abstract string AddParameterAddButton { get; set; }

    //Tank List page
    public abstract string TankListTitle { get; set; }
    public abstract string TankListLabel { get; set; }
    public abstract string TankListNoLabel { get; set; }
    public abstract string TankListAddButton { get; set; }

    //Edit Tank page
    public abstract string EditTankTitle { get; set; }
    public abstract string EditTankLabel { get; set; }
    public abstract string EditTankName { get; set; }
    public abstract string EditTankSaveButton { get; set; }
    public abstract string EditTankDeleteButton { get; set; }

    //Add tank page
    public abstract string AddTankTitle { get; set; }
    public abstract string AddTankLabel { get; set; }
    public abstract string AddTankName { get; set; }
    public abstract string AddTankDescription { get; set; }
    public abstract string AddTankAddButton { get; set; }

    //Links
    public abstract string Home { get; set; }
    public abstract string Privacy { get; set; }
    public abstract string Users { get; set; }
    public abstract string Plcs { get; set; }
    public abstract string Sensors { get; set; }
    public abstract string Parameters { get; set; }
    public abstract string Tanks { get; set; }
    public abstract string Logout { get; set; }
    public abstract string Login { get; set; }
   
}