using System;
using System.Collections.Generic;
using System.Text;
using Testing.PruebaUnitaria;
using Xunit;

namespace Testing.Capicua.Tests
{
    public class CapicuaServiceTests
    {
        //Pasa la prueba
        [Fact]
        public void TestCapicua202() {

            CapicuaService service = new CapicuaService();

           bool result =  service.VerifyCapicua(202);

            Assert.True(result);

        }

        //Falla la prueba
        [Fact]
        public void TestCapicua203()
        {

            CapicuaService service = new CapicuaService();

            bool result = service.VerifyCapicua(203);

            Assert.True(result);

        }

        //Pasa la prueba
        [Fact]
        public void TestCapicua4224()
        {

            CapicuaService service = new CapicuaService();

            bool result = service.VerifyCapicua(4224);

            Assert.True(result);

        }
    }
}
