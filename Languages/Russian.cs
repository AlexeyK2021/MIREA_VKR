using System.Diagnostics.CodeAnalysis;

namespace opcUaWebMVC;

public class Russian: Language
{
    public override string LangName { get; set; } = "Русский язык";
    
    public override string AuthPageTitle { get; set; } = "Аутентификация";
    public override string AuthPageLabel { get; set; } = "Страница аутентификации";
    public override string AuthPageUsernamePlaceholder { get; set; } = "Логин";
    public override string AuthPagePasswordPlaceholder { get; set; } = "Пароль";
    public override string AuthPageLanguageSelectLabel { get; set; } = "Язык";
    public override string AuthPageLoginButton { get; set; } = "Войти";
    
    public override string UserListTitle { get; set; } = "Пользователи";
    public override string UserListUserTypeAdmin { get; set; } = "Администратор";
    public override string UserListUserTypeOperator { get; set; } = "Оператор";
    public override string UserListLabel { get; set; } = "Список пользователей";
    public override string UserListAddButton { get; set; } = "Добавить";
    
    public override string AddUserTitle { get; set; } = "Новый пользователь";
    public override string AddUserLabel { get; set; } = "Новый пользователя";
    public override string AddUserNamePlaceholder { get; set; } = "Имя";
    public override string AddUserLoginPlaceholder { get; set; } = "Логин";
    public override string AddUserPasswordPlaceholder { get; set; } = "Пароль";
    public override string AddUserIsAdmin { get; set; } = "Администратор";
    public override string AddUserAddButton { get; set; } = "Добавить";
    
    public override string EditUserTitle { get; set; } = "Изменение пользователя";
    public override string EditUserName { get; set; } = "Имя";
    public override string EditUserLogin { get; set; } = "Логин";
    public override string EditUserNewPassword { get; set; } = "Новый пароль";
    public override string EditUserSaveButton { get; set; } = "Сохранить";
    public override string EditUserDeleteUser { get; set; } = "Удалить пользователя";
    
    public override string PlcListLabel { get; set; } = "Список контроллеров";
    public override string PlcListNoPlcLabel { get; set; } = "В системе нет контроллеров";
    public override string PlcListAddButton { get; set; } = "Добавить контроллер";
    public override string PlcListTitle { get; set; } = "Контроллеры";
    
    public override string AddPlcTitle { get; set; } = "Новый контроллер";
    public override string AddPlcLabel { get; set; } = "Добавление нового контроллера";
    public override string AddPlcModel { get; set; } = "Модель";
    public override string AddPlcTank { get; set; } = "Ёмкость";
    public override string AddPlcIp { get; set; } = "IP";
    public override string AddPlcPort { get; set; } = "OPC порт";
    public override string AddPlcAddButton { get; set; } = "Добавить";
    
    public override string EditPlcTitle { get; set; } = "Изменение ПЛК";
    public override string EditPlcLabel { get; set; } = "Изменение контроллера";
    public override string EditPlcModel { get; set; } = "Модель";
    public override string EditPlcTank { get; set; } = "Ёмкость";
    public override string EditPlcIp { get; set; } = "IP";
    public override string EditPlcPort { get; set; } = "OPC порт";
    public override string EditPlcSaveButton { get; set; } = "Сохранить";
    public override string EditPlcDeleteButton { get; set; } = "Удалить ПЛК";
    
    public override string SensorsListTitle { get; set; } = "Датчики";
    public override string SensorsListLabel { get; set; } = "Список датчиков";
    public override string SensorsListNoSensorLabel { get; set; } = "В системе нет датчиков";
    public override string SensorListAddButton { get; set; } = "Добавить";
    
    public override string AddSensorTitle { get; set; } = "Новый датчик";
    public override string AddSensorLabel { get; set; } = "Добавление нового датчика";
    public override string AddSensorName { get; set; } = "Имя";
    public override string AddSensorModel { get; set; } = "Модель";
    public override string AddSensorPlc { get; set; } = "Подключен к ПЛК";
    public override string AddSensorParameter { get; set; } = "Параметр измерения";
    public override string AddSensorAddButton { get; set; } = "Добавить";
    
    public override string ParameterListTitle { get; set; } = "Параметры";
    public override string ParameterListLabel { get; set; } = "Список параметров для измерения";
    public override string ParameterListNoLabel { get; set; } = "В системе нет параметров для изменерения";
    public override string ParameterListAddButton { get; set; } = "Добавить";
    
    public override string AddParameterTitle { get; set; } = "Новый параметр";
    public override string AddParameterLabel { get; set; } = "Добавление нового параметра";
    public override string AddParameterName { get; set; } = "Имя";
    public override string AddParameterMinValue { get; set; } = "Минимальное значение";
    public override string AddParameterMaxValue { get; set; } = "Максимальное значение";
    public override string AddParameterMinValueOpcTopic { get; set; } = "Топик минимального значения";
    public override string AddParameterMaxValueOpcTopic { get; set; } = "Топик максимального значения";
    public override string AddParameterCurrValueOpcTopic { get; set; } = "Топик текущего значения";
    public override string AddParameterType { get; set; } = "Тип параметра";
    public override string AddParameterAddButton { get; set; } = "Добавить";
    
    public override string TankListTitle { get; set; } = "Ёмкости";
    public override string TankListLabel { get; set; } = "Список ёмкостей";
    public override string TankListNoLabel { get; set; } = "В системе нет ёмкостей";
    public override string TankListAddButton { get; set; } = "Добавить";
    
    public override string EditTankTitle { get; set; } = "Изменение ёмкости";
    public override string EditTankLabel { get; set; } = "Изменение ёмкости";
    public override string EditTankName { get; set; } = "Имя";
    public override string EditTankSaveButton { get; set; } = "Сохранить";
    public override string EditTankDeleteButton { get; set; } = "Удалить ёмкость";
    
    public override string AddTankTitle { get; set; } = "Новая ёмкость";
    public override string AddTankLabel { get; set; } = "Добавление новой ёмкости";
    public override string AddTankName { get; set; } = "Имя";
    public override string AddTankDescription { get; set; } = "Описание";
    public override string AddTankAddButton { get; set; } = "Добавить";
    
    public override string Home { get; set; } = "Главная";
    public override string Privacy { get; set; } = "Конфиденциальность";
    public override string Users { get; set; } = "Пользователи";
    public override string Plcs { get; set; } = "ПЛК";
    public override string Sensors { get; set; } = "Датчики";
    public override string Parameters { get; set; } = "Параметры";
    public override string Tanks { get; set; } = "Ёмкости";
    public override string Logout { get; set; } = "Выход";
    public override string Login { get; set; } = "Вход";
}