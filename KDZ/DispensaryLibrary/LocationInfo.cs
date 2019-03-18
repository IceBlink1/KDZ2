using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispensaryLibrary
{
    public class LocationInfo
    {
        static List<string> AppropriateAdministrativeAreaList = new List<string> { "Западный административный округ",
            "Центральный административный округ", "Северо-Западный административный округ", "Северо-Восточный административный округ",
            "Восточный административный округ",
        "Юго-Восточный административный округ", "Юго-Западный административный округ", "Южный административный округ",
        "Северный административный округ", "Зеленоградский административный округ"};
        static List<List<string>> AppropriateDistrictList = new List<List<string>>();

        string area;
        string district;

        static LocationInfo()
        {
            AppropriateDistrictList.Add(new List<string> { "район Раменки", "район Ново-Переделкино", "район Фили-Давыдково",
                "район Дорогомилово", "район Крылатское", "район Солнцево", "район Филёвский Парк" });
            AppropriateDistrictList.Add(new List<string> { "район Арбат", "Таганский район", "Тверской район", "Басманный район", "район Якиманка",
                "район Хамовники", "район Замоскворечье", "Красносельский район" });
            AppropriateDistrictList.Add(new List<string> { "район Покровское-Стрешнево", "район Щукино", "район Южное Тушино", "район Хорошёво-Мнёвники" });
            AppropriateDistrictList.Add(new List<string> { "Останкинский район", "район Ростокино", "район Лианозово",
                "Алексеевский район", "район Марьина Роща", "Лосиноостровский район" });
            AppropriateDistrictList.Add(new List<string> { "район Богородское", "район Соколиная Гора", "район Измайлово",
                "район Перово", "район Вешняки", "район Гольяново", "район Сокольники", "район Преображенское" });
            AppropriateDistrictList.Add(new List<string> { "Южнопортовый район", "район Лефортово", "район Кузьминки", "район Текстильщики",
                "район Марьино", "район Люблино" });
            AppropriateDistrictList.Add(new List<string> { "район Черёмушки", "Обручевский район", "Академический район", "Ломоносовский район", "район Северное Бутово" });
            AppropriateDistrictList.Add(new List<string> { "район Москворечье-Сабурово", "район Нагатинский Затон", "район Царицыно", "Донской район",
                "Нагорный район", "район Бирюлёво Восточное", "Даниловский район" });
            AppropriateDistrictList.Add(new List<string> { "Головинский район", "Тимирязевский район", "район Коптево", "Войковский район", "Хорошёвский район" });
            AppropriateDistrictList.Add(new List<string> { "район Крюково", "район Старое Крюково", "район Матушкино", "район Савёлки" });
        }

        public LocationInfo(string area, string district)
        {
            Area = area;
            District = district;
        }

        public string Area
        {
            get
            {
                return area;
            }
            private set
            {
                if (!IsAppropriateArea(value))
                    throw new IllegalAreaException("В списке допустимых значений не содержится: " + value);
                area = value;
            }
        }

        public string District
        {
            get
            {
                return district;
            }
            private set
            {
                if (!IsAppropriateDistrict(value))
                    throw new IllegalDistrictException("В указанном АО нет такого района: " + value);
                district = value;
            }
        }

        private bool IsAppropriateArea(string area) => AppropriateAdministrativeAreaList.Contains(area);
        private bool IsAppropriateDistrict(string district) =>
            AppropriateDistrictList[AppropriateAdministrativeAreaList.IndexOf(Area)].Contains(district);
    }
}
