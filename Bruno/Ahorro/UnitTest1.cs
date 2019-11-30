using System;
using Bruno;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ahorro
{
    [TestClass]
    public class Ahorro
    {
        [TestMethod]
        public void DepositarDinero()
        {
            //Arrange
            string Nombre = "BRUNO";
            double Ahorroactual = 1500;
            double Deposito1 = 100;
            double AhorroEsperado = 1600;
            Person cliente = new Person(Nombre, Ahorroactual);
            //Act
            cliente.Save(Deposito1);
            double AhorroObtenido = cliente.SaveMoney;
            //Assert
            Assert.AreEqual(AhorroEsperado, AhorroObtenido, 0.001, "No se ha depositado correctamente");
        }
        [TestMethod]
        public void RetirarDinero()
        {
            //Arrange
            string Nombre = "BRUNO";
            double Ahorroactual = 1500;
            double Retiro1 = 100;
            double AhorroEsperado = 1400;
            Person cliente = new Person(Nombre, Ahorroactual);
            //Act
            cliente.Spend(Retiro1);
            double AhorroObtenido = cliente.SaveMoney;
            //Assert
            Assert.AreEqual(AhorroEsperado, AhorroObtenido, 0.001, "No se ha retirado correctamente");//0.001 es el valor maximo de la diferencia entre el esperado y el obtenido
        
        }
        [TestMethod]
        public void CambioNombre()
        {
            //Arrange
            string Nombre1 = "Pepito";
            double Monto = 100; //Necesario para crear el objeto
            string Nombre2 = "Carlitos";        
            Person cliente2 = new Person(Nombre1, Monto);
            //Act
            cliente2.ChangeName(Nombre2);
            string nombreobtenido = cliente2.Name;
            //Assert
            Assert.AreNotEqual(nombreobtenido, Nombre2);

        }
    }
}

