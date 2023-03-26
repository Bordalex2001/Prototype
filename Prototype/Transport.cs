using System;

namespace Prototype
{
    interface IClone
    {
        Transport Clone();
    }
    class Engine
    {
        string name; //название двигателя
        string fuel; //топливо (тип топлива)
        double fuelConsumption; //расход топлива
        public Engine() {}
        public Engine(string name, string fuel, double fuelConsumption)
        {
            this.name = name;
            this.fuel = fuel;
            this.fuelConsumption = fuelConsumption;
        }
        public override string ToString()
        {
            return $"Engine Name: {name}\nFuel: {fuel}\nFuel consumption: {fuelConsumption}";
        }
    }
    abstract class Transport : IClone
    {
        protected string name; //название транспортного средства
        protected int year; //год выпуска
        protected int speed; //максимальная скорость
        protected Engine engine; //двигатель транспортного средства
        public Transport() { }
        public Transport(string name, int year, int speed, Engine engine)
        {
            this.name = name;
            this.year = year;
            this.speed = speed;
            this.engine = engine;
        }
        public Transport(Transport transport)
        {
            this.name = transport.name;
            this.year = transport.year;
            this.speed = transport.speed;
            this.engine = transport.engine;
        }
        public abstract Transport Clone();
        public override string ToString()
        {
            return $"Name: {name}\nYear: {year}\nSpeed: {speed}\n{engine}";
        }
    }
    class Ship : Transport
    {
        protected string kind; //тип корабля
        public Ship() { }
        public Ship(string name, int year, int speed, Engine engine, string kind)
        {
            this.name = name;
            this.year = year;
            this.speed = speed;
            this.engine = engine;
            this.kind = kind;
        }
        public Ship(Ship ship) : base(ship) { }
        public override Transport Clone()
        {
            return new Ship(this);
        }
        public override string ToString()
        {
            return base.ToString() + $"\nKind: {kind}";
        }
    }
    class Truck : Transport
    {
        protected string body; //тип кузова
        public Truck() { }
        public Truck(string name, int year, int speed, Engine engine, string body)
        {
            this.name = name;
            this.year = year;
            this.speed = speed;
            this.engine = engine;
            this.body = body;

        }
        public Truck(Truck truck) : base(truck) { }
        public override Transport Clone()
        {
            return new Truck(this);
        }
        public override string ToString()
        {
            return base.ToString() + $"\nBody: {body}";
        }
    }
    class Plane : Transport
    {
        protected int altitude; //максимальная высота
        public Plane() { }
        public Plane(string name, int year, int speed, Engine engine, int altitude)
        {
            this.name = name;
            this.year = year;
            this.speed = speed;
            this.engine = engine;
            this.altitude = altitude;
        }
        public Plane(Plane plane) : base(plane) { }
        public override Transport Clone()
        {
            return new Plane(this);
        }
        public override string ToString()
        {
            return base.ToString() + $"\nAltitude: {altitude}";
        }
    }
}
