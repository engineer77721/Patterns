﻿using System;

namespace State
{
    /*Паттерн "Состояние"
     * Управляет изменением поведения объекта при изменении его внутреннего состояния. Внешне это выглядит так, словно объект меняет свой класс
     * Создали интерфейс IState - в мне описанна сигнатура методов, которыми должно обладать любое состояние нашего автомата с жевачками
     * Реализовали каждое состояние - в методах недоступных для данного состояния - выводим сообщение об ошибке, в доступном - соотвествующая логика и переход
     * к след состоянию. Этот переход осуществляется следующим образом - есть класс GumballMachine - который представляет наш автомат с жевачками. У него есть
     * объекты всех состояний, есть текущее состояние и есть метод для установки текущего состояния в нужное. Так вот для изменения состояния мы просто
     * вызываем метод SetState и устанавливаем нужное состояние. Данный паттерн избавил нас от множества проверок - вся логика поведения автомата при определенном
     * событии была разложена по классам состояний. 
     */
    class Program
    {
        static void Main(string[] args)
        {
            var gumballMachine = new GumballMachine(10);

            gumballMachine.TurnCrank();
            gumballMachine.EjectQuarter();

            gumballMachine.InsertQuarter();
            gumballMachine.EjectQuarter();

            gumballMachine.InsertQuarter();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();


            Console.ReadKey(true);
        }
    }
}