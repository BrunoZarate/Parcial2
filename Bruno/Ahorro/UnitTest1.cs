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
            Assert.AreEqual(AhorroEsperado, AhorroObtenido, 0.001, "No se ha retirado correctamente");

        }
    }
}

