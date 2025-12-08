using WarriorStatus;

namespace TestWarriorStatus
{
    [TestClass]
    public sealed class TestWarriorStatusMethods
    {
        [TestMethod]
        public void TC1_Verify_Status_With_Max_HP()
        {
            // Arrange
            double speed, attack;
            bool canRun;
            string color, status;

            // Act
            MyMethods.CalculateWarriorStatus(100, out status, out speed, out attack, out canRun, out color);

            // Assert
            Assert.AreEqual("Healthy", status);
            Assert.AreEqual(100, speed);
            Assert.AreEqual(100, attack);
            Assert.IsTrue(canRun);
            Assert.AreEqual("normal", color);
        }

        [TestMethod]
        public void TC2_Verify_Transition_From_Healthy_To_Injured_With_75_HP()
        {
            // Arrange
            double speed, attack;
            bool canRun;
            string color, status;

            // Act
            MyMethods.CalculateWarriorStatus(75, out status, out speed, out attack, out canRun, out color);

            // Assert
            Assert.AreEqual("Injured", status);
            Assert.AreEqual(90, speed);
            Assert.AreEqual(100, attack);
            Assert.IsTrue(canRun);
            Assert.AreEqual("normal", color);
        }

        [TestMethod]
        public void TC3_Verify_Transition_To_Severely_Injured_With_50_HP()
        {
            // Arrange
            double speed, attack;
            bool canRun;
            string color, status;

            // Act
            MyMethods.CalculateWarriorStatus(50, out status, out speed, out attack, out canRun, out color);

            // Assert
            Assert.AreEqual("Severely Injured", status);
            Assert.AreEqual(70, speed);
            Assert.AreEqual(80, attack);
            Assert.IsTrue(canRun);
            Assert.AreEqual("normal", color);
        }

        [TestMethod]
        public void TC4_Verify_Protection_Against_HP_Above_Maximum()
        {
            // Arrange
            double speed, attack;
            bool canRun;
            string color, status;

            // Act
            MyMethods.CalculateWarriorStatus(105, out status, out speed, out attack, out canRun, out color);

            // Assert - HP is limited to 100 internally
            Assert.AreEqual("Healthy", status);
            Assert.AreEqual(100, speed);
            Assert.AreEqual(100, attack);
            Assert.IsTrue(canRun);
            Assert.AreEqual("normal", color);
        }

        // Additional tests for boundary values
        [TestMethod]
        public void Verify_Dead_Status_With_0_HP()
        {
            // Arrange
            double speed, attack;
            bool canRun;
            string color, status;

            // Act
            MyMethods.CalculateWarriorStatus(0, out status, out speed, out attack, out canRun, out color);

            Assert.AreEqual("Dead", status);
            Assert.AreEqual(0, speed);
            Assert.AreEqual(0, attack);
            Assert.IsTrue(canRun);
            Assert.AreEqual("red", color);
        }

        [TestMethod]
        public void Verify_Critical_Status_With_1_HP()
        {
            // Arrange
            double speed, attack;
            bool canRun;
            string color, status;

            // Act
            MyMethods.CalculateWarriorStatus(1, out status, out speed, out attack, out canRun, out color);

            Assert.AreEqual("Critical", status);
            Assert.AreEqual(50, speed);
            Assert.AreEqual(50, attack);
            Assert.IsTrue(canRun);
            Assert.AreEqual("normal", color);
        }

        [TestMethod]
        public void Verify_Critical_Status_With_25_HP()
        {
            // Arrange
            double speed, attack;
            bool canRun;
            string color, status;

            // Act
            MyMethods.CalculateWarriorStatus(25, out status, out speed, out attack, out canRun, out color);

            Assert.AreEqual("Critical", status);
        }

        [TestMethod]
        public void Verify_Severely_Injured_Status_With_26_HP()
        {
            // Arrange
            double speed, attack;
            bool canRun;
            string color, status;

            // Act
            MyMethods.CalculateWarriorStatus(26, out status, out speed, out attack, out canRun, out color);

            Assert.AreEqual("Severely Injured", status);
        }

        [TestMethod]
        public void Verify_Severely_Injured_Status_With_50_HP()
        {
            // Arrange
            double speed, attack;
            bool canRun;
            string color, status;

            // Act
            MyMethods.CalculateWarriorStatus(50, out status, out speed, out attack, out canRun, out color);

            Assert.AreEqual("Severely Injured", status);
        }

        [TestMethod]
        public void Verify_Injured_Status_With_51_HP()
        {
            // Arrange
            double speed, attack;
            bool canRun;
            string color, status;

            // Act
            MyMethods.CalculateWarriorStatus(51, out status, out speed, out attack, out canRun, out color);

            Assert.AreEqual("Injured", status);
        }

        [TestMethod]
        public void Verify_Injured_Status_With_75_HP()
        {
            // Arrange
            double speed, attack;
            bool canRun;
            string color, status;

            // Act
            MyMethods.CalculateWarriorStatus(75, out status, out speed, out attack, out canRun, out color);

            Assert.AreEqual("Injured", status);
        }

        [TestMethod]
        public void Verify_Healthy_Status_With_76_HP()
        {
            // Arrange
            double speed, attack;
            bool canRun;
            string color, status;

            // Act
            MyMethods.CalculateWarriorStatus(76, out status, out speed, out attack, out canRun, out color);

            Assert.AreEqual("Healthy", status);
        }

        [TestMethod]
        public void Verify_Healthy_Status_With_100_HP()
        {
            // Arrange
            double speed, attack;
            bool canRun;
            string color, status;

            // Act
            MyMethods.CalculateWarriorStatus(100, out status, out speed, out attack, out canRun, out color);

            Assert.AreEqual("Healthy", status);
        }

    }
}
