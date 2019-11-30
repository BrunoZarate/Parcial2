
namespace Bruno
{
    public class Person
    {

        private string _name;
        private double _savemoney;
        public string Name { get; }
        public double SaveMoney { get { return _savemoney; } }

        public Person(string name, double savemoney)
        {
            Name = name;
            _savemoney = savemoney;
        }

        public void Save(double save)
        {
            _savemoney += save;
        }

        public void Spend(double save)
        {
            _savemoney += save;  //Para Retirar dinero la funcion deberia restar, en lugar de sumar, por tanto aqui esta el error
            //_savemoney=savemoney-save;  es la linea sugerida para que el metodo funcione correctamente
        }
        public void ChangeName(string name)
        {
            _name = name;
        }

    }

}
