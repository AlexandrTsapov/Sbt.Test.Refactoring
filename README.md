# Sbt.Test.Refactoring
Спроектировать и реализовать прототип framework-а для моделирования игрового мира.

Основной сценарий использования:
На двухмерной карте расположены юниты.  
У каждого юнита есть состояние, характеризующееся набором свойств.  
•	Пользователи отправляют команды, на которые юниты реагируют, тем или иным образом меняя своё состояние.  
•	Например, у Трактора есть состояние: позиция (координаты на поле) и направление, поддерживает команды: повернуться по часовой стрелке (изменить направление), двигаться вперёд (в зависимости от текущего направления изменить одну из координат на 1 пункт).  
•	В комплекте с фреймворком поставляется некоторый набор юнитов и команд. Первоначальный трактор должен органично влиться в этот набор юнитов (отрефакторить код).  
•	Требуется предусмотреть механизмы расширения, позволяющие клиентам (другим разработчикам, которые используют фреймворк как библиотеку) добавлять поддержку новых юнитов и новых команд (не меняя при этом исходный код фреймворка). Должна быть реализована возможность переиспользования одних и тех же команд разными юнитами. Дизайн фреймворка должен позволять пользователям реализовывать новые юниты, умеющие исполнять как старые, так и новые команды. Например, пользовательский юнит Танк мог бы исполнять оригинальные команды движения и поворота. При этом старые юниты новым командам обучать не требуется (например, заставлять трактор стрелять не нужно).

В качестве примера предлагается реализовать следующий набор юнитов.  
В комплекте с framework-ом:  
•	Трактор. Состояние: позиция, направление. Команды: движение вперёд, поворот. (Отрефакторить код изначального Трактора).  
•	Камень. Состояние: только позиция. Команды не поддерживаются.  
•	Ветер. Состояние: только направление. Команды: поворот.  

Юниты, добавляемые пользователем библиотеки (реализовывать не требуется, просто для информации разработчика):  
•	Охранная башня. Состояние: позиция, направление, запас патронов. Команды: поворот, выстрел.  
•	Танк. Состояние: позиция, направление, запас патронов. Команды: движение вперёд, поворот, выстрел. 

Для демонстрации работоспособности требуется реализовать возможность отправки одной команды группе разнородных юнитов. Например, как в компьютерных стратегиях - на карте расположен некоторый набор разнообразных юнитов. Пользователь рамкой выделяет группу юнитов и отправляет команду. Юниты, которые могут её исполнить - исполняют, остальные - игнорируют. Для демонстрации подобного сценария в коде можно объявить коллекцию, заполнить её несколькими различными юнитами, затем отправить всем юнитам из этой коллекции какую-либо команду. Это можно реализовать в виде юнит-теста или main-метода.
