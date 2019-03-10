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
        [Test]
        public void Should_remove_an_element_when_selected()
        {
            DictionaryGeneric dico = new DictionaryGeneric();
            dico.Add("Hello","titi");
            dico.Remove("Hello");
            var value = dico.Get("Hello");
            Check.That(value).IsNull();
        }
        // UPDATE ELEMENT
        [Test]
        public void Should_update_an_element_when_selected()
        {
            DictionaryGeneric dico = new DictionaryGeneric();
            dico.Add("Hello","titi");
            dico.Update("Hello","lala");
            var value = dico.Get("Hello");
            Check.That(value).IsEqualTo("lala");
        }

        [Test]
        public void Should_return_size_when_selected()
        {
            DictionaryGeneric dico = new DictionaryGeneric();
            dico.Add("Hello","titi");
            dico.Add("HILLA","titi");
            var size = dico.Size();
            Check.That(size).IsEqualTo(2);
        }

        // ADD NEW SIZE
        // [Test]
        // public void Should_calculate_the_size_of_20_pourcent()
        // {
        //     int res = (10 * 30/100);
        //     DictionaryGeneric dico = new DictionaryGeneric();
        //     dico.Add("a","titi");
        //     dico.Add("b","titi");
        //     dico.Add("c","titi");
        //     dico.Add("d","titi");
        //     dico.Add("e","titi");
        //     dico.Add("f","titi");
        //     dico.Add("g","titi");
        //     dico.Add("h","titi");
        //     dico.Add("i","titi");
        //    // dico.Add("POPOPO","titi");
        //     Check.That(dico.Size()).IsEqualTo(13);
        // }

        
    }

}