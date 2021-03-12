using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ToDoIt.Data;
using ToDoIt.Model;

namespace ToDoIt.Tests.Model
{
    public class TodoTests
    {
        [Fact]
        public void DescriptionIsString()
        {

            //Arrange
            int todoId = 1;
            string description = "work";
            bool done = false;
            Person assignee = new Person(6, "Haris", "Pontus");

            //Act
            Todo todo = new Todo(todoId, description);

            //Assert
            Assert.Equal(todoId, todo.TodoId);
            Assert.Equal(description, todo.Description);
            Assert.Equal(done, todo.Done);

        }

        [Fact]
        public void BoolIsFalse()
        {
            //Arrange
            int todoId = 1;
            string description = "Work";
            bool done = false;
            Person assignee = new Person(6, "Haris", "Pontus");

            //Act
            Todo todo = new Todo(todoId, description);

            //Assert
            Assert.Equal(done, todo.Done);
        }
        [Fact]
        public void NullDescription()
        {
            //Arrange
            int todoId = 1;
            string description = "remains";
            bool done = false;
            Person assignee = new Person(6, "Haris", "Pontus");
            Todo todo = new Todo(todoId, description);

            //Act
            todo.Description = null;
            string result = todo.Description;

            //Assert
            Assert.Equal(description, todo.Description);
        }

    }
}


