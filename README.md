# Разработка информационной системы для контрольно-пропускной системы общежития

## Содержание

[Введение](#introdution)

[1 Описание предметной области](#domainDescription)

[2 Сравнительный анализ существующих программных решений](#existSoftware)

[3 Разработка](#Development)

[4 Проектирование системы](#Systemdesign)

[5 Тестирование системы](#Checkingandtestingthesystem)

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

Контрольно-пропускной режим - это комплекс организационно-правовых ограничений и правил, устанавливающих порядок
пропуска через контрольно-пропускные пункты в отдельные здания (помещения) сотрудников объекта, посетителей, транспорта
и материальных средств. Контрольно-пропускной режим является одним из ключевых моментов в организации системы
безопасности на предприятии. С этих позиций контрольно-пропускной режим представляет собой комплекс организационных
мероприятий (административно-ограничительных), инженерно-технических решений и действий службы безопасности.

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

Организация контрольно-пропускного режима отличается определенной сложностью. Дело в том, что механизм осуществления
контрольно-пропускного режима основывается на применении "запретов" и "ограничений" в отношении субъектов, пересекающих
границы охраняемых объектов, для обеспечения интересов предприятия. Такой механизм должен быть безупречным с точки
зрения соответствия требованиям действующего законодательства.

Первая система - СКУД RusGuard.

Аппаратная инфраструктура СКУД КПП не может функционировать без специального программного обеспечения (ПО). Компания
RusGuard предлагает собственный программный комплекс, которые идеально подойдет для обслуживания сетевых СКУД, в том
числе, СКУД КПП. Наше ПО представляет собой модульное решение, способное управлять всеми типами устройств СКУД, в том
числе теми, которыми обычно комплектуются СКУД КПП.ПО RusGuard поддерживает работу с охранными устройствами, а также
некоторым другим интегрированным в систему оборудованием, что позволяет «делегировать» сетевой СКУД новые задачи уровня
предприятия.

Вторая система - BIO5.

В контрольно-пропускном зале устраиваются проходы, которые оборудуются техническими средствами охраны и физическими
барьерами. В комплект оборудования, как правило, входят:
средства механизации, автоматизации системы контроля доступа; физические барьеры (ограждения, турникеты, калитки);
основное и резервное освещение; средства связи и тревожной сигнализации; системы видеоконтроля. В качестве средств
контроля доступа могут использоваться различные турникеты. Турникеты предназначены для управления потоками людей и
регулирования входа (выхода). В последнее время наиболее широкое распространение получили электромеханические турникеты.
Электромеханические турникеты, в отличие от громоздких и неудобных в управлении механических, легко управляются с пульта
охранника и могут работать в составе автоматизированной системы контроля доступа.

Ни одна из представленных систем КПП не дподходит для нашей предметой области, поэтому, разработаем её самостоятельно.

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
создаем его, определяем в простраство имен и описываем класс:
![img_1.png](img_1.png)
Рисунок 3 - класс

Создаем такие классы для всех сущностей из ER - диаграммы:

![img.png](img.png)

Рисунок 4 - список классов

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

Так же для работы приложения были разработаны и созданы хранилища, позволяющие хранить, актуализировать и использовать
информацию

![img_2.png](img_2.png)

Рисунок 5 - Список хранилищ

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

***

Затем созадём контроллеры, которые будут взаимодействовать с ранее созданными классами :

![img_3.png](img_3.png)

Рисунок 6 - Список хранилищ

Пример кода контроллера посетителя:

```csharp
using Microsoft.AspNetCore.Mvc;
using Zamay.Domain;
using Zamay.Repository;

namespace Zamay.Controllers
{
    [ApiController]
    [Route("/visitor")]
    public class VisitorController : ControllerBase
    {
        [HttpPut("Register")]
        public Visitor Create(Visitor visitor)
        {
            Storage.VisitorStorage.Create(visitor);
            return visitor; // Метод для регистрации в общежитии
        }
    }
}
```

Пример кода контроллера вахтера:

```csharp
using Microsoft.AspNetCore.Mvc;
using Zamay.Domain;
using Zamay.Repository;
using static System.DateTime;

namespace Zamay.Controllers
{
    [ApiController]
    [Route("/watchman")]
    public class Vahter : ControllerBase
    {
        [HttpPatch("RestorePass")]
        public Pass RestorePass(int PassNumber, Pass newPass)
        {
            return Storage.PassStorage.Update(PassNumber, newPass);
        }

        [HttpPut("LeavingTimeRegister")]
        public string Create(LeavingTime leavingTime, int visitorNumber)
        {
            if (!Storage.VisitorStorage.Check(visitorNumber)) return "Scam";
            leavingTime.LeaveTime = Now;
            Storage.LeavingTimeStorage.Create(leavingTime);
            return leavingTime + " " + "Добавлено!";
        }

        [HttpPut("ArrivalTimeRegister")]
        public string Create(ArrivalTime arrivalTime, int visitorNumber)
        {
            if (!Storage.VisitorStorage.Check(visitorNumber)) return "Scam";
            arrivalTime.EnterTime = Now;
            Storage.ArrivalTimeStorage.Create(arrivalTime);
            return arrivalTime + " " + "Добавлено!";
        }
        
        [HttpGet("GetInfoAboutVisitor")]
        public Visitor Read(int visitorNumber)
        {
            return Storage.VisitorStorage.Read(visitorNumber);
        }

        [HttpDelete("DeleteVisitor")]
        public bool Delete(int visitorNumber)
        {
            return Storage.VisitorStorage.Delete(visitorNumber);
        }
    }
}
```

<a name="Checkingandtestingthesystem"/>

## Тестирование системы

При запуске приложения открывается вкладка браузера Swagger UI, в котором представлены котроллеры и их операции над
сущностями.

![img_5.png](img_5.png)

Рисунок 7 - Список контроллеров

Проверка работы методов CRUD (Create - создание, Read - чтение, Update - обновление, Delete - удаление) в контроллере
Watchman

![img_6.png](img_6.png)

Рисунок 8 - Список методов оператора Watchman

1. Метод Create позволяет добавлять новую запись в хранилище.

![img_7.png](img_7.png)

Рисунок 9 - Окно метода Create, в которое мы вносим значения

После ввода данных, сервер нам отвечает :
![img_8.png](img_8.png)

Рисунок 10 - Результат срабатывания метода Create

2. Метод Read позволяет нам считать запись из хранилища.

![img_9.png](img_9.png)

Рисунок 11 - Окно метода Read

![img_10.png](img_10.png)

Рисунок 12 - Результат срабатывания метода Read

3. Функция Update, служащая для редактирования записей в хранилище по идентификатору. В окно PassNumber мы вводим номер
   пропуска, у которого мы желаем изменить данные, а в Request body новые данные.

![img_11.png](img_11.png)

Рисунок 13 - Окно функции Update

![img_12.png](img_12.png)

Рисунок 14 - Результат срабатывания функции Update

4. Метод Delete, служащий для удаления записей по идентификатору.

![img_13.png](img_13.png)

Рисунок 15 - Окно метода Delete

![img_14.png](img_14.png)

Рисунок 16 - Результат срабатывания метода Delete

***
<a name="Conclusion"/>

## Заключение

В результате реализации проекта "Контрольно пропускной пункт общежития", решены следующие задачи: регистрация
посетителей общежития, выдача пропусков и их проверка, также хранение информации о входах-выходах из общежития. Также
были получены новые навыки по созданию веб-сайта и основных операций CRUD. Данная информационная система выполняет
функции создания, чтения, редактирования и удаления записей. Это система актуальна и перспективна для дальнейшей
разработки.

<a name="Listofliterature"/>

## Список используемой литературы

[1] https://ntagil.org/bezopas/info.php?SECTION_ID=1216

[2] http://bio5.ru/articles/kontrol-dostupa/kontrolno-propusknoi-rezhim-na-predpriyatii.html