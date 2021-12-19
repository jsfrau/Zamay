# Разработка информационной системы для контрольно-пропускной системы общежития

## Содержание

[Введение](#introdution)

[1) Описание предметной области](#domainDescription)

[2) Сравнительный анализ существующих программных решений](#existSoftware)

[3) Разработка](#Development)

[4) Проектирование системы](#Systemdesign)

[5) Тестирование системы](#Checkingandtestingthesystem)

[Заключение](#Conclusion)

[Список литературы](#Listofliterature)

<a name="introdution"/>

# Введение

## *Общее описание*

Ещё с древности у людей существовала потребность в отличии своих от чужих. Постепенно, вместе с развитием человечества,
у нас стали появляться разлиные решения для данной потребности. В нашем случае рассматривается задача контроля входа и
выхода в студенческое общежитие. Схожие пропускные системы существуют уже давно и успели себя зарекомендовать. Например,
в таких видах организаций, как : Военные, Образовательные, Частные.

Из данных областей нашей более близка система, используемая в образовательных или частных организациях.

<a name="domainDescription"/>

# 1 Описание предметной области

Общежи́тие — место временного проживания для приезжих студентов и учащихся на время учёбы, сезонных рабочих на время
работы, службы или ставшее постоянным для работников учреждения. Соответственно, следует различать студенческие и
рабочие общежития.

Контрольно-пропускной пункт — в военном деле, а также в гражданской сфере обеспечения безопасности имеет два значения:
специально оборудованное место на объекте для осуществления контроля в установленном порядке за проходом людей и
проездом транспортных средств на территорию объекта.

В данной системе участвует 3 лица: посетитель, вахтёр, комендант.

Посетитель - это тот, кто взаимодействет с КПП, обеспечивающем *"отсеивание"* своих от чужих. Вахтёр - важное лицо,
взаимодействующее с пропусками. Комендант - заселяет посетителей и выписывает пропуски. Все вместе, они образуют
информационную систему.

Задача:

-создание информационного сайта обеспечивающего возможность входа и выхода из общежития, регистрацию в нём и выдачу
пропусков;

Проблема :

-быстрый, регестрируемый вход и выход из общежития;

<a name="existSoftware"/>

# 2 Сравнительный анализ существующих программных решений

Во многих образовательных организациях, в том числе и в ВУЗе, которому принадлежит наше общежитие, установлена и
работает схожая система. Схожесть в участвующих лицах и их обязаннастях.

Планируется схожая контрольно пропускная система ввиде пункта, находящегося в общежитии. Отличие данного решения от
других заключается в в уникальности системы взаимодействия сущностей, в краткости и четкости, бесперебойной работе.

<a name="Development"/>

# 3 Разработка

Начинается разработка с рисования use case диаграммы, на которой будут находится основные действующие лица.

![image](https://github.com/jsfrau/Zamay/blob/main/Pictures/UseCase.drawio.svg)

Рисунок 1 - Use Case диаграмма

Затем, используя эти наброски, нарисуем DFD диаграмму для лучшего представления движения данных в нашей области. Для
наглядности, все действующие лица выделены своими цветами. Посетитель(красный) Вахтёр(синий) Комендант(желтый)

![image](https://github.com/jsfrau/Zamay/blob/main/Pictures/KPP_DFD.drawio.svg)

Рисунок 2 - Data Flow диаграмма

![image](https://github.com/jsfrau/Zamay/blob/main/Pictures/KPP_ER.svg)

На основе этой диаграммы мы создаем классы в среде C# и описываем их с параметрами и их типами данных. Для этого мы
создаем контроллер, определяем его в определенное простраство имен и описываем класс:
![img_1.png](img_1.png)

Создаем такие классы для всех сущностей из ER - диаграммы:

![img.png](img.png)

Пример кода класса "Посетитель":

```csharp
namespace Zamay.Domain
{
    public class Visitor
    {
        public int VisitorNumber { get; set; }
        public Document Documents { get; set; }
        public bool check { get; set; }
    }
}
```

Пример кода класса "Время входа":

```csharp
using System;

namespace Zamay.Domain
{
    public class ArrivalTime
    {
        public int ArrivalTimeNumber { get; set; }
        public DateTime EnterTime { get; set; }
        public Pass Pass { get; set; }
    }
}
```

***

Так же для работы приложения были разработаны и созданы хранилища, позволяющие хранить, актуализировать и использовать информацию (Рис 5)

![img_2.png](img_2.png)
Рис.5

Пример кода хранилища посетителей :

```csharp
using System.Collections.Generic;
using Zamay.Domain;

namespace Zamay.Repository
{
    public class VisitorStorage
    {
        private Dictionary<int, Visitor> visitors { get; } = new();

        public void Create(Visitor visitor)
        {
            visitors.Add(visitor.VisitorNumber, visitor);
        }

        public Visitor Read(int visitorNumber)
        {
            return visitors[visitorNumber];
        }

        public Visitor Update(int visitorNumber, Visitor newVisitor)
        {
            visitors[visitorNumber] = newVisitor;
            return visitors[visitorNumber];
        }

        public bool Delete(int visitorNumber)
        {
            return visitors.Remove(visitorNumber);
        }

        public bool Check(int visitorNumber)
        {
            if (visitors[visitorNumber] != null)
                return true;
            return false;
        }
    }
}
```

Пример кода хранилища входов :

```csharp
using System.Collections.Generic;

namespace Zamay.Domain
{
    public class ArrivalTimeStorage
    {
        private Dictionary<int, ArrivalTime> ArrivalTimes { get; } = new();

        public void Create(ArrivalTime arrivalTime)
        {
            ArrivalTimes.Add(arrivalTime.ArrivalTimeNumber, arrivalTime);
        }

        public ArrivalTime Read(int arrivalTimeNumber)
        {
            return ArrivalTimes[arrivalTimeNumber];
        }

        public ArrivalTime Update(int arrivalTimeNumber, ArrivalTime newArrivalTime)
        {
            ArrivalTimes[arrivalTimeNumber] = newArrivalTime;
            return ArrivalTimes[arrivalTimeNumber];
        }

        public bool Delete(int arrivalTimeNumber)
        {
            return ArrivalTimes.Remove(arrivalTimeNumber);
        }
    }
}
```
