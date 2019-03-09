using System;
using NFluent;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        LinkedListCustom linked = null;

        [SetUp]
        public void Init()
        {
            var nextNode = new Node(24);
            var node = new Node(12);
            node.AddNextNode(nextNode);
            linked = new LinkedListCustom(node);
        }


        [Test]
        public void Should_return_Node_with_specific_numbers()
        {
            var node = new Node(12);
            Check.That(node.Number).IsEqualTo(12);
        }

        [Test]
        public void Should_add_next_node_specific_numbers()
        {
            var nextNode = new Node(24);
            var node = new Node(12);
            node.AddNextNode(nextNode);
            Check.That(node.Next.Number).IsEqualTo(24);
        }

        [Test]
        public void Should_parcour_list_when_nodes_added()
        {
            var nextNode = new Node(24);
            var node = new Node(12);
            node.AddNextNode(nextNode);
            var linked = new LinkedListCustom(node);
            var contentsExpected = $"12-24";
            string contents = linked.GetAllNodesContents();
            Check.That(contents).IsEqualTo(contentsExpected);
        }

        [Test]
        public void Should_throw_an_exception_when_node_null_added(){
             var linked = new LinkedListCustom(null);
             Check.ThatCode( () => linked.GetAllNodesContents()).Throws<Exception>();
        }

        [Test]
        public void Should_count_all_the_nodes_when_called_from_the_linked_list()
        {
            var attentedSize = 2;
            var nodeNumber = linked.Size();
            Check.That(nodeNumber).IsEqualTo(attentedSize);
        }


        [Test]
        public void Should_return_a_node_when_index_is_specified()
        {
            Node result = linked.GetNodeWithSpecificIndex(0);
            Check.That(result.Number).IsEqualTo(12);
        }

        [Test]
        public void Should_return_random_number()
        {
            Node nodeResult =linked.RandomNode();
            Check.That(nodeResult).IsNotNull();
        }
    }
}