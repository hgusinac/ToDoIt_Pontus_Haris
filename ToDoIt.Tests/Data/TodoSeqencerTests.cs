using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ToDoIt.Data;
using ToDoIt.Model;

namespace ToDoIt.Tests.Data
{
    public class TodoSeqencersTests
    {
        [Fact]
        public void NewIdIsOne()
        {
            TodoSeqencer.reset();
            //Arrange

            //Act
            int newid = TodoSeqencer.nextTodoId();

            //Assert
            Assert.Equal(1, newid);
        }
        [Fact]
        public void IsisTwo()
        {
            //Arrange
            //TodoSeqencer Idcounter = new TodoSeqencer();
            //Act
            int newid = TodoSeqencer.nextTodoId();
            newid = TodoSeqencer.nextTodoId();
            //Assert
            Assert.Equal(2, newid);

        }
        [Fact]
        public void TryToResetId()
        {
            //Arrange
            //TodoSeqencer Idcounter = new TodoSeqencer();
            //Act
            int newid = TodoSeqencer.nextTodoId();
            newid = TodoSeqencer.nextTodoId();
            TodoSeqencer.reset();
            newid = TodoSeqencer.nextTodoId();
            //Assert
            Assert.Equal(1, newid);

        }
        [Fact]
        public void TryToResetIdAddNew()
        {
            //Arrange
            //TodoSeqencer Idcounter = new TodoSeqencer();
            //Act
            int newid = TodoSeqencer.nextTodoId();
            newid = TodoSeqencer.nextTodoId();
            TodoSeqencer.reset();
            newid = TodoSeqencer.nextTodoId();
            newid = TodoSeqencer.nextTodoId();
            newid = TodoSeqencer.nextTodoId();
            newid = TodoSeqencer.nextTodoId();
            //Assert
            Assert.Equal(4, newid);

        }
        [Fact]
        public void ResetReset()
        {
            //Arrange
            //TodoSeqencer Idcounter = new TodoSeqencer();
            //Act
            int newid = TodoSeqencer.nextTodoId();
            newid = TodoSeqencer.nextTodoId();
            TodoSeqencer.reset();
            TodoSeqencer.reset();
            newid = TodoSeqencer.nextTodoId();
            //Assert
            Assert.Equal(1, newid);

        }

    }
}
