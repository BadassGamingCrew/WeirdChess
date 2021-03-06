﻿// <auto-generated />
namespace UnitTests.SettingTestCases
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using WeirdChess.Enums;
    using WeirdChess.Interfaces;
    using WeirdChess.Exceptions;

    [TestClass]
    public abstract class AbstractISettingTestCase
    {
        private ISetting setting;
        private SettingType settingType;
        private object settingValue;
        private object[] possibleValues;
        private object[] invalidValues;

        protected abstract ISetting GetSetting();
        protected abstract ISetting GetSetting(object value);
        protected abstract SettingType GetSettingType();
        protected abstract object GetDefaultValue();
        protected abstract object[] GetAllowedValues();
        protected abstract object[] GetInvalidValues();

        [ClassInitialize]
        public void BaseInit(TestContext context)
        {
        }

        [TestInitialize]
        public void SetUp()
        {
            this.settingType = this.GetSettingType();
            this.settingValue = this.GetDefaultValue();
            this.possibleValues = this.GetAllowedValues();
            this.invalidValues = this.GetInvalidValues();
        }

        [TestCleanup]
        public void TearDown()
        {
            this.setting = null;
            this.settingType = default(SettingType);
            this.settingValue = null;
            this.possibleValues = null;
        }

        [TestMethod]
        public void TestTypePropertyIsNotNullWithDefaultConstructor()
        {
            this.setting = this.GetSetting();
            Assert.IsNotNull(this.setting.Type);
        }

        [TestMethod]
        public void TestTypePropertyReturnsCorrectValueWithDefaultConstructor()
        {
            this.setting = this.GetSetting();
            Assert.AreEqual(this.settingType, this.setting.Type);
        }

        [TestMethod]
        public void TestValuePropertyIsNotNullWithDefaultConstructor()
        {
            this.setting = this.GetSetting();
            Assert.IsNotNull(this.setting.Value);
        }

        [TestMethod]
        public void TestValuePropertyReturnsCorrectValueWithDefaultConstructor()
        {
            this.setting = this.GetSetting();
            Assert.AreEqual(this.settingValue, this.setting.Value);
        }

        [TestMethod]
        public void TestTypePropertyIsNotNullWithNonDefaultConstructor()
        {
            foreach (object value in this.possibleValues)
            {
                this.setting = this.GetSetting(value);
                Assert.IsNotNull(this.setting.Type);
            }
        }

        [TestMethod]
        public void TestTypePropertyReturnsCorrectValueWithNonDefaultConstructor()
        {
            foreach (object value in this.possibleValues)
            {
                this.setting = this.GetSetting(value);
                Assert.AreEqual(this.settingType, this.setting.Type);
            }
        }

        [TestMethod]
        public void TestValuePropertyIsNotNullWithNonDefaultConstructor()
        {
            foreach (object value in this.possibleValues)
            {
                this.setting = this.GetSetting(value);
                Assert.IsNotNull(this.setting.Value);
            }
        }

        [TestMethod]
        public void TestValuePropertyReturnsCorrectValueWithNonDefaultConstructor()
        {
            foreach (object value in this.possibleValues)
            {
                this.setting = this.GetSetting(value);
                Assert.AreEqual(value, this.setting.Value);
            }
        }

        [TestMethod]
        public void TestConstructorThrowsExceptionWhenInvalidValueIsUsed()
        {
            foreach (object value in this.invalidValues)
            {
                try
                {
                    this.setting = this.GetSetting(value);
                    Assert.Fail("Expected exception not found. Value: " + value);
                }
                catch (InvalidSettingValueException)
                {
                    // expected
                }
            }
        }
    }
}
