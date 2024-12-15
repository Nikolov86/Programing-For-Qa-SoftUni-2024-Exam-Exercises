using System;
using System.Text;
using System.Linq;
using NUnit.Framework;
using System.Collections.Generic;
using static NUnit.Framework.Constraints.Tolerance;

namespace TestApp.Tests;

public class ParkingSystemTests
{
    [Test]
    public void Test_Contructor_CheckInitialEmptyCarCollectionAndCount()
    {
        // Arrange
        ParkingSystem parkingSystem = new ParkingSystem();

        

        // Act
        List<string> parkedCars = parkingSystem.GetAllParkedCars();
        int carCount = parkingSystem.CarCount;

        // Assert
        Assert.IsEmpty(parkedCars);
        
    }

    [Test]
    public void Test_ParkCar_ValidCarNumber_AddNewCar()
    {
        // Arrange
        ParkingSystem parkingSystem = new ParkingSystem();
        string carNumber = "ABC123";

        // Act
        parkingSystem.ParkCar(carNumber);
        List<string> parkedCars = parkingSystem.GetAllParkedCars();

        // Assert
        Assert.AreEqual(1, parkedCars.Count);
        Assert.Contains(carNumber, parkedCars);
    }

    [Test]
    public void Test_ParkCar_NullOrEmptyCarNumber_ThrowsArgumentException()
    {
        // Arrange
        ParkingSystem parkingSystem = new ParkingSystem();
        string nullCarNumber = null;
        string emptyCarNumber = "";
        string whitespaceCarNumber = " ";

        // Act & Assert
        Assert.Throws<ArgumentException>(() => parkingSystem.ParkCar(nullCarNumber));
        Assert.Throws<ArgumentException>(() => parkingSystem.ParkCar(emptyCarNumber));
        Assert.Throws<ArgumentException>(() => parkingSystem.ParkCar(whitespaceCarNumber));
    }
    

    [Test]
    public void Test_RemoveCar_ValidCarNumber_RemoveFirstCar()
    {
        // Arrange
        ParkingSystem parkingSystem = new ParkingSystem();
        string carNumber1 = "ABC123";
        string carNumber2 = "DEF456";

        parkingSystem.ParkCar(carNumber1);
        parkingSystem.ParkCar(carNumber2);

        // Act
        parkingSystem.RemoveCar(carNumber1);
        List<string> parkedCars = parkingSystem.GetAllParkedCars();

        // Assert
        Assert.AreEqual(1, parkedCars.Count);
        Assert.Contains(carNumber2, parkedCars);
        Assert.IsFalse(parkedCars.Contains(carNumber1));
    }

    [Test]
    public void Test_RemoveCar_NullOrEmptyCarNumber_ThrowsArgumentException()
    {
        // Arrange
        ParkingSystem parkingSystem = new ParkingSystem();
        string nullCarNumber = null;
        string emptyCarNumber = "";
        string whitespaceCarNumber = " ";

        // Act & Assert
        Assert.Throws<ArgumentException>(() => parkingSystem.RemoveCar(nullCarNumber));
        Assert.Throws<ArgumentException>(() => parkingSystem.RemoveCar(emptyCarNumber));
        Assert.Throws<ArgumentException>(() => parkingSystem.RemoveCar(whitespaceCarNumber));
    }

    [Test]
    public void Test_GetAllParkedCars_AddAndRemoveCar_ReturnsExpectedCarsCollection()
    {
        // Arrange
        ParkingSystem parkingSystem = new ParkingSystem();
        string carNumber1 = "ABC123";
        string carNumber2 = "DEF456";
        string carNumber3 = "GHI789";

        // Act
        parkingSystem.ParkCar(carNumber1);
        parkingSystem.ParkCar(carNumber2);
        parkingSystem.ParkCar(carNumber3);
        parkingSystem.RemoveCar(carNumber2);

        List<string> parkedCars = parkingSystem.GetAllParkedCars();

        // Assert
        Assert.AreEqual(2, parkedCars.Count);
        Assert.Contains(carNumber1, parkedCars);
        Assert.Contains(carNumber3, parkedCars);
        Assert.IsFalse(parkedCars.Contains(carNumber2));
    }
}
