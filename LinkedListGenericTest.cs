using System;
using System.Text;
using NFluent;
using NUnit.Framework;

namespace Tests {

    internal class LinkedListGenericTest {

        
        [Test]
        public void Should_return_the_type_added()
        {
           var linkedList = new LinkedListGeneric<string>();
           linkedList.Add("12");
           string number = linkedList.Get(0);
           Check.That(number).IsEqualTo("12");
        }

        [Test]
        public void Should_return_multiple_type_added()
        {
           var linkedList = new LinkedListGeneric<string>();
           linkedList.Add("ZAZAZ");
           linkedList.Add("AZAZA");
           string val1 = linkedList.Get(0);
           string val2 = linkedList.Get(1);
           Check.That(val1).IsEqualTo("ZAZAZ");
           Check.That(val2).IsEqualTo("AZAZA");
        }
        // fix problem with int type.
        // update
        [Test]
        public void Should_update_a_node_when_indice_is_speciefied()
        {
            var linkedList = new LinkedListGeneric<string>();
            linkedList.Add("ZAZAZ");
            linkedList.Add("AZAZA");
            linkedList.Update(1,"Hello");
            string val1 = linkedList.Get(1);
           Check.That(val1).IsEqualTo("Hello");

        }

        // size
        [Test]
        public void Should_return_size_of_list_when_asked()
        {
             var linkedList = new LinkedListGeneric<string>();
            linkedList.Add("ZAZAZ");
            linkedList.Add("AZAZA");
            linkedList.Add("AZAZAQQA");
            var size = linkedList.Size();
            Check.That(size).IsEqualTo(3);
        }
        //  delete;
        [Test]
        public void Should_delete_a_node_when_indice_is_specified()
        {
            var linkedList = new LinkedListGeneric<string>();
            linkedList.Add("ZAZAZ");
            linkedList.Add("AZAZA");
            linkedList.Add("AZAZA1");
            linkedList.Add("AZAZA2");
            linkedList.Delete(2);
            var size = linkedList.Size();
            Check.That(size).IsEqualTo(3);
            Check.That(linkedList.Get(2)).IsEqualTo("AZAZA2");
        }

        [Test]
        public void Should_delete_a_node_when_indice_is_specified_in_the_begining_of_list()
        {
            var linkedList = new LinkedListGeneric<string>();
            linkedList.Add("ZAZAZ");
            linkedList.Add("AZAZA");
            linkedList.Add("AZAZA1");
            linkedList.Add("AZAZA2");
            linkedList.Delete(0);
            var size = linkedList.Size();
            Check.That(size).IsEqualTo(3);
            Check.That(linkedList.Get(0)).IsEqualTo("AZAZA");
        }

         [Test]
        public void Should_delete_a_node_when_indice_is_specified_in_the_end_of_list()
        {
            var linkedList = new LinkedListGeneric<string>();
            linkedList.Add("A");
            linkedList.Add("B");
            linkedList.Add("C");
            linkedList.Add("D");
            linkedList.Delete(3);
            var size = linkedList.Size();
            Check.That(size).IsEqualTo(3);
            Check.That(linkedList.Get(2)).IsEqualTo("C");
        }
        //  Node Exist
        [Test]
        public void Should_find_the_first_node_when_value_searched_and_return_a_boolean_validation()
        {
            var linkedList = new LinkedListGeneric<string>();
            linkedList.Add("A");
            linkedList.Add("B");
            linkedList.Add("C");
            linkedList.Add("C");
            linkedList.Add("D");
            Check.That(linkedList.Exist("C")).IsTrue();
       }
       


    }
}