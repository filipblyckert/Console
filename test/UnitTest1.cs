
using adressbok;

namespace test

{
    public class UnitTest1
    {
        [Fact]
        public void TestAddContact()
        {
            var adressbook = new adressbok.AdressBook();
            var contact = new Contact("börje", "23", "ASDH<SDBCHV", "123gatan");
            adressbook.AddContact(contact);
            Assert.Contains(adressbook._contacts, contact => contact == contact);
        }
    }
}