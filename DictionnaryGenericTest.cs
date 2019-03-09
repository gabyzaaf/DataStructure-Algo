using System;
using NFluent;
using NUnit.Framework;

namespace DictionaryTests {

    public class DictionaryGenericTest{
        [Test]
        public void Should_generate_a_hash_when_information_added()
        {
            DictionaryGeneric dico = new DictionaryGeneric();
            int hash = dico.GetHashFrom("Hello");
            Check.That(hash).IsEqualTo(5);
        }

        [Test]
        public void Should_add_and_return_an_element_when_you_called()
        {
            DictionaryGeneric dico = new DictionaryGeneric();
            dico.Add("Hello","titi");
            string titiValue = dico.Get("Hello");
            Check.That(titiValue).IsEqualTo("titi");
        }

        [Test]
        public void Should_throw_an_exception_when_key_already_exist()
        {
             DictionaryGeneric dico = new DictionaryGeneric();
             dico.Add("Hello","titi");
             Check.ThatCode(() => {dico.Add("Hello","titi");}).Throws<Exception>();
        }

        [Test]
        public void Should_return_an_null_when_key_not_existing_getted()
        {
            DictionaryGeneric dico = new DictionaryGeneric();
            dico.Add("Hello","titi");
            var value = dico.Get("KEY");
            Check.That(value).IsNull();
        }

        // REMOVE ELEMENT
        public void Should_remove_an_element_when_selected()
        {
            
        }
        // UPDATE ELEMENT

        // ADD NEW SIZE


        
    }

}