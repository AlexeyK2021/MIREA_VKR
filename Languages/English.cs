namespace opcUaWebMVC;

public class English : Language
{
    public override string LangName { get; set; } = "English";
    
    public override string AuthPageTitle { get; set; } = "Auth Page";
    public override string AuthPageLabel { get; set; } = "Authentication Page";
    public override string AuthPageUsernamePlaceholder { get; set; } = "Your login";
    public override string AuthPagePasswordPlaceholder { get; set; } = "Your password";
    public override string AuthPageLanguageSelectLabel { get; set; } = "Language";
    public override string AuthPageLoginButton { get; set; } = "Login";
    
    public override string UserListTitle { get; set; } = "Users";
    public override string UserListUserTypeAdmin { get; set; } = "Admin";
    public override string UserListUserTypeOperator { get; set; } = "Operator";
    public override string UserListLabel { get; set; } = "User list";
    public override string UserListAddButton { get; set; } = "New user";
    
    public override string AddUserTitle { get; set; } = "New User";
    public override string AddUserLabel { get; set; } = "Create new user";
    public override string AddUserNamePlaceholder { get; set; } = "Username";
    public override string AddUserLoginPlaceholder { get; set; } = "Login";
    public override string AddUserPasswordPlaceholder { get; set; } = "Password";
    public override string AddUserIsAdmin { get; set; } = "Is Admin";
    public override string AddUserAddButton { get; set; } = "Save";
    
    public override string EditUserTitle { get; set; } = "Edit User";
    public override string EditUserName { get; set; } = "Name";
    public override string EditUserLogin { get; set; } = "Login";
    public override string EditUserNewPassword { get; set; } = "New Password";
    public override string EditUserSaveButton { get; set; } = "Save";
    public override string EditUserDeleteButton { get; set; } = "Delete user";
    
    public override string PlcListLabel { get; set; } = "PLC list";
    public override string PlcListNoPlcLabel { get; set; } = "No PLC";
    public override string PlcListAddButton { get; set; } = "Add PLC";
    public override string PlcListTitle { get; set; } = "PLC list";
    public override string Tank { get; set; } = "Tank";

    public override string AddPlcTitle { get; set; } = "New PLC";
    public override string AddPlcLabel { get; set; } = "Create new PLC";
    public override string AddPlcModel { get; set; } = "Model";
    public override string AddPlcTank { get; set; } = "Tank";
    public override string AddPlcIp { get; set; } = "IP";
    public override string AddPlcPort { get; set; } = "OPC Port";
    public override string AddPlcAddButton { get; set; } = "Save";
    
    public override string EditPlcTitle { get; set; } = "Edit PLC";
    public override string EditPlcLabel { get; set; } = "Edit PLC info";
    public override string EditPlcModel { get; set; } = "PLC Model";
    public override string EditPlcTank { get; set; } = "PLC Tank";
    public override string EditPlcIp { get; set; } = "PLC IP";
    public override string EditPlcPort { get; set; } = "OPC Port";
    public override string EditPlcSaveButton { get; set; } = "Save";
    public override string EditPlcDeleteButton { get; set; } = "Delete";
    
    public override string SensorsListTitle { get; set; } = "Sensors List";
    public override string SensorsListLabel { get; set; } = "Sensors";
    public override string SensorsListNoSensorLabel { get; set; } = "No sensors!";
    public override string SensorListAddButton { get; set; } = "Add";
    
    public override string AddSensorTitle { get; set; } = "New sensor";
    public override string AddSensorLabel { get; set; } = "Add sensor";
    public override string AddSensorName { get; set; } = "Name";
    public override string AddSensorModel { get; set; } = "Model";
    public override string AddSensorPlc { get; set; } = "PLC";
    public override string AddSensorParameter { get; set; } = "Parameter";
    public override string AddSensorAddButton { get; set; } = "Add";

    public override string EditSensorTitle { get; set; } = "Edit Sensor";
    public override string EditSensorLabel { get; set; } = "Edit Sensor";
    public override string EditSensorName { get; set; } = "Name";
    public override string EditSensorModel { get; set; } = "Model";
    public override string EditSensorPlc { get; set; } = "Connected to PLC";
    public override string EditSensorParameter { get; set; } = "Parameter";
    public override string EditSensorSaveButton { get; set; } = "Save";

    public override string ParameterListTitle { get; set; } = "Parameters";
    public override string ParameterListLabel { get; set; } = "Parameters list";
    public override string ParameterListNoLabel { get; set; } = "No parameters";
    public override string ParameterListAddButton { get; set; } = "Add";
    
    public override string AddParameterTitle { get; set; } = "New parameter";
    public override string AddParameterLabel { get; set; } = "Create new parameter";
    public override string AddParameterName { get; set; } = "Name";
    public override string AddParameterMinValue { get; set; } = "Minimal value";
    public override string AddParameterMaxValue { get; set; } = "Maximum value";
    public override string AddParameterMinValueOpcTopic { get; set; } = "Min value OPC name";
    public override string AddParameterMaxValueOpcTopic { get; set; } = "Max value OPC name";
    public override string AddParameterCurrValueOpcTopic { get; set; } = "Current value OPC name";
    public override string AddParameterType { get; set; } = "Type";
    public override string AddParameterAddButton { get; set; } = "Add";
    
    public override string EditParameterTitle { get; set; } = "Edit Parameter";
    public override string EditParameterLabel { get; set; } = "Edit Parameter";
    public override string EditParameterName { get; set; } = "Name";
    public override string EditParameterMinValue { get; set; } = "Minimum value";
    public override string EditParameterMaxValue { get; set; } = "Maximum value";
    public override string EditParameterMinValueOpcTopic { get; set; } = "Min value OPC name";
    public override string EditParameterMaxValueOpcTopic { get; set; } = "Max value OPC name";
    public override string EditParameterCurrValueOpcTopic { get; set; } = "Current value OPC name";
    public override string EditParameterType { get; set; } = "Type";
    public override string EditParameterSaveButton { get; set; } = "Save";
    public override string EditParameterDeleteButton { get; set; } = "Delete";

    public override string TankListTitle { get; set; } = "Tanks";
    public override string TankListLabel { get; set; } = "Tanks list";
    public override string TankListNoLabel { get; set; } = "No tanks!";
    public override string TankListAddButton { get; set; } = "New tank";
    
    public override string EditTankTitle { get; set; } = "Edit tank";
    public override string EditTankLabel { get; set; } = "Edit tank";
    public override string EditTankName { get; set; } = "Name";
    public override string EditTankSaveButton { get; set; } = "Save";
    public override string EditTankDeleteButton { get; set; } = "Delete";
    public override string AddTankTitle { get; set; } = "New Tank";
    public override string AddTankLabel { get; set; } = "Create new tank";
    public override string AddTankName { get; set; } = "Name";
    public override string AddTankDescription { get; set; } = "Description";
    public override string AddTankAddButton { get; set; } = "Add";
    public override string Home { get; set; } = "Home";
    public override string Privacy { get; set; } = "Privacy";
    public override string Users { get; set; } = "Users";
    public override string Plcs { get; set; } = "PLCs";
    public override string Sensors { get; set; } = "Sensors";
    public override string Parameters { get; set; } = "Parameters";
    public override string Tanks { get; set; } = "Tanks";
    public override string Logout { get; set; } = "Log out";
    public override string Login { get; set; } = "Log in";
   

    public English()
    { }
}