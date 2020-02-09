using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.Windows;

namespace TheFormTest
{
    [TestClass]
    public class GUITest : TheFormsSession
    {
        [TestMethod]
        public void TestNombreGUI()
        {
            string TextToTest = "Me Llamo Forest Gump";
            
            WindowsElement NameTextBox = session.FindElementByAccessibilityId("NameTextBox");
            WindowsElement SaludarButton = session.FindElementByAccessibilityId("SaludarButton");
            WindowsElement SaludoLabel = session.FindElementByAccessibilityId("SaludoLabel");

            //Ponemos el Texto Necesario Para Saludar
            NameTextBox.SendKeys(TextToTest);

            //Haceos click en el Botón
            SaludarButton.Click();

            //Comprobamos que el texto sea correcto();
            Assert.AreEqual<string>(TextToTest, SaludoLabel.Text);

        }

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            Setup(context);
        }

        [ClassCleanup]
        public static void ClassCleanUp()
        {
            //Cerrar
            TearDown();
        }
    }
}
