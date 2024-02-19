using TestTask.ItemsService.Domain.Entities;
using TestTask.ItemsService.Domain.Entities.AttributeValues;

namespace TestTask.ItemsService.Infrastructure
{
    internal static class InjectedData
    {
        public static List<RefAttributes> RefAttributes = new()
        {
            #region футболки
            new RefAttributes
            {
                Id = 1,
                AttributeName = "Размер",
                CategoryId = 1,
                DataType = Domain.Enums.CategoryAttributesDataTypes.StringValue
            },
            new RefAttributes
            {
                Id = 2,
                AttributeName = "Материал",
                CategoryId = 1,
                DataType = Domain.Enums.CategoryAttributesDataTypes.StringValue
            },
            new RefAttributes
            {
                Id = 3,
                AttributeName = "Бренд",
                CategoryId = 1,
                DataType = Domain.Enums.CategoryAttributesDataTypes.StringValue
            },
            new RefAttributes
            {
                Id = 4,
                AttributeName = "Цвет",
                CategoryId = 1,
                DataType = Domain.Enums.CategoryAttributesDataTypes.StringValue
            },
            #endregion
            #region фильмы
            new RefAttributes
            {
                Id = 5,
                AttributeName = "Длительность",
                CategoryId = 2,
                DataType = Domain.Enums.CategoryAttributesDataTypes.TimeValue
            },
            new RefAttributes
            {
                Id = 6,
                AttributeName = "Дата выпуска",
                CategoryId = 2,
                DataType = Domain.Enums.CategoryAttributesDataTypes.DateValue
            },
            new RefAttributes
            {
                Id = 7,
                AttributeName = "Режисер",
                CategoryId = 2,
                DataType = Domain.Enums.CategoryAttributesDataTypes.StringValue
            },
            new RefAttributes
            {
                Id = 8,
                AttributeName = "Актер",
                CategoryId = 2,
                DataType = Domain.Enums.CategoryAttributesDataTypes.StringValue
            },
            #endregion  
        };

        public static List<CategoryEntity> Categories = new()
        {
            new CategoryEntity
            {
                Id = 1,
                CategoryName = "Футболки"
            },
            new CategoryEntity
            {
                Id = 2,
                CategoryName = "Фильмы"
            }
        };

        public static List<ItemEntity> Items = new()
        {
            #region футболки
            new ItemEntity
            {
                Id = 1,
                CategoryId = 1,
                Description = "Нужна стильная, но при этом универсальная база для спортивных образов? Отличный вариант — футболка Demix.",
                Name = "Футболка мужская Demix",
                Price = 3990
            },
            new ItemEntity
            {
                Id = 2,
                CategoryId = 1,
                Description = "Нужна стильная, но при этом универсальная база для спортивных образов? Отличный вариант — футболка Demix.",
                Name = "Футболка мужская Demix",
                Price = 3990
            },
            new ItemEntity
            {
                Id = 3,
                CategoryId = 1,
                Description = "Нужна стильная, но при этом универсальная база для спортивных образов? Отличный вариант — футболка Demix.",
                Name = "Футболка мужская Demix",
                Price = 3990
            },
            new ItemEntity
            {
                Id = 4,
                CategoryId = 1,
                Description = "Нужна стильная, но при этом универсальная база для спортивных образов? Отличный вариант — футболка Demix.",
                Name = "Футболка мужская Demix",
                Price = 3990
            },
            #endregion
            #region фильмы
            new ItemEntity
            {
                Id = 5,
                CategoryId = 2,
                Description = "Фильм повествует о череде событий, произошедших в Голливуде в 1969 году, на закате его «золотого века». По сюжету, известный ТВ актер Рик Далтон и его дублер Клифф Бут пытаются найти свое место в стремительно меняющемся мире киноиндустрии",
                Name = "Однажды в… Голливуде BLUE RAY",
                Price = 2000
            },
            new ItemEntity
            {
                Id = 6,
                CategoryId = 2,
                Description = "Пятеро наёмных убийц оказываются в одном сверхскоростном экспрессе. Они узнают, что их миссии связаны, и пытаются выяснить, кто и зачем собрал их вместе.\r\n",
                Name = "Быстрее пули",
                Price = 3000
            },
            #endregion
        };

        public static List<StringAttributeValuesEntity> StringAttributes = new()
        {
            #region футболки
            #region футболка 1
            #region размеры
            new StringAttributeValuesEntity
            {
                Id = 1,
                ItemId = 1,
                RefAttributeId = 1,
                Value = "44-46"
            },
            new StringAttributeValuesEntity
            {
                Id = 2,
                ItemId = 2,
                RefAttributeId = 1,
                Value = "48-50"
            },
            new StringAttributeValuesEntity
            {
                Id = 3,
                ItemId = 3,
                RefAttributeId = 1,
                Value = "52-54"
            },
            new StringAttributeValuesEntity
            {
                Id = 4,
                ItemId = 4,
                RefAttributeId = 1,
                Value = "56-58"
            },
            new StringAttributeValuesEntity
            {
                Id = 5,
                ItemId = 1,
                RefAttributeId = 1,
                Value = "60-62"
            },
            #endregion
            #region цвета
            new StringAttributeValuesEntity
            {
                Id = 6,
                ItemId = 1,
                RefAttributeId = 4,
                Value = "Белый"
            },
            new StringAttributeValuesEntity
            {
                Id = 7,
                ItemId = 2,
                RefAttributeId = 4,
                Value = "Черный"
            },
            new StringAttributeValuesEntity
            {
                Id = 8,
                ItemId = 3,
                RefAttributeId = 4,
                Value = "Серый"
            },
            new StringAttributeValuesEntity
            {
                Id = 9,
                ItemId = 4,
                RefAttributeId = 4,
                Value = "Белый"
            },
            new StringAttributeValuesEntity
            {
                Id = 10,
                ItemId = 1,
                RefAttributeId = 4,
                Value = "Зеленый"
            },
            #endregion
            #region материалы
            new StringAttributeValuesEntity
            {
                Id = 11,
                ItemId = 1,
                RefAttributeId = 2,
                Value = "Хлопок"
            },
            new StringAttributeValuesEntity
            {
                Id = 12,
                ItemId = 2,
                RefAttributeId = 2,
                Value = "Хлопок"
            },
            new StringAttributeValuesEntity
            {
                Id = 13,
                ItemId = 3,
                RefAttributeId = 2,
                Value = "Хлопок"
            },
            new StringAttributeValuesEntity
            {
                Id = 14,
                ItemId = 4,
                RefAttributeId = 2,
                Value = "Хлопок"
            },
            new StringAttributeValuesEntity
            {
                Id = 15,
                ItemId = 1,
                RefAttributeId = 2,
                Value = "Хлопок"
            },
            #endregion
            #region бренды
            new StringAttributeValuesEntity
            {
                Id = 16,
                ItemId = 1,
                RefAttributeId = 3,
                Value = "Хлопок"
            },
            new StringAttributeValuesEntity
            {
                Id = 17,
                ItemId = 2,
                RefAttributeId = 3,
                Value = "Хлопок"
            },
            new StringAttributeValuesEntity
            {
                Id = 18,
                ItemId = 3,
                RefAttributeId = 3,
                Value = "Хлопок"
            },
            new StringAttributeValuesEntity
            {
                Id = 19,
                ItemId = 4,
                RefAttributeId = 3,
                Value = "Хлопок"
            },
            new StringAttributeValuesEntity
            {
                Id = 20,
                ItemId = 1,
                RefAttributeId = 3,
                Value = "Хлопок"
            },
            #endregion
            #endregion
            #endregion
            #region фильмы
            #region Однажды в Голливуде
            new StringAttributeValuesEntity
            {
                Id = 21,
                ItemId = 5,
                RefAttributeId = 7,
                Value = "Квентин Тарантино"
            },
            new StringAttributeValuesEntity
            {
                Id = 22,
                ItemId = 5,
                RefAttributeId = 8,
                Value = "Марго Робби - Шарон Тейт"
            },
            new StringAttributeValuesEntity
            {
                Id = 23,
                ItemId = 5,
                RefAttributeId = 8,
                Value = "Брэд Питт - Клифф Бут"
            },
            new StringAttributeValuesEntity
            {
                Id = 24,
                ItemId = 5,
                RefAttributeId = 8,
                Value = "Леонардо Ди Каприо - Рик Далтон"
            },
            #endregion
            #region Быстрее пули
            new StringAttributeValuesEntity
            {
                Id = 25,
                ItemId = 6,
                RefAttributeId = 7,
                Value = "Дэвид Литч"
            },
            new StringAttributeValuesEntity
            {
                Id = 26,
                ItemId = 6,
                RefAttributeId = 8,
                Value = "Аарон Тейлор-Джонсон - Танджерин"
            },
            new StringAttributeValuesEntity
            {
                Id = 27,
                ItemId = 6,
                RefAttributeId = 8,
                Value = "Брэд Питт - Божья коровка"
            },
            new StringAttributeValuesEntity
            {
                Id = 28,
                ItemId = 6,
                RefAttributeId = 8,
                Value = "Джоуи Кинг - Prince"
            },
            #endregion
            #endregion
        };

        public static List<DateAttributeValuesEntity> DateAttributeValues = new()
        {
            #region фильмы
            #region Однажды в Голливуде
            new DateAttributeValuesEntity
            {
                Id = 1,
                ItemId = 5,
                RefAttributeId = 6,
                Value = new DateTime(2019, 7, 26)
            },
            #endregion
            #region Быстрее пули
            new DateAttributeValuesEntity
            {
                Id = 2,
                ItemId = 6,
                RefAttributeId = 6,
                Value = new DateTime(2022, 8, 5)
            }
            #endregion
            #endregion
        };

        public static List<TimeAttributeValuesEntity> TimeAttributeValuesEntity = new()
        {
            
            #region фильмы
            #region Однажды в Голливуде
            new TimeAttributeValuesEntity
            {
                Id = 1,
                ItemId = 5,
                RefAttributeId = 5,
                Value = TimeSpan.FromMinutes(160)
            },
            #endregion
            #region Быстрее пули
            new TimeAttributeValuesEntity
            {
                Id = 2,
                ItemId = 6,
                RefAttributeId = 5,
                Value = TimeSpan.FromMinutes(126)
            }
            #endregion
            #endregion
        };
    }
}
