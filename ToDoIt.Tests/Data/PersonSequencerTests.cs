using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ToDoIt.Data;
using ToDoIt.Model;

namespace ToDoIt.Tests
{
    public class PersonSequencerTests
    {

        [Fact]
        public void NewIDIsOne()
        {

            PersonSequencer.reset();
            //Arrange
            //TodoSeqencer Idcounter = new TodoSeqencer();
            //Act
            int newid = PersonSequencer.nextPersonID();
                                                       
            Assert.Equal(1, newid);
        }
        [Fact]
        public void IDisTwo()
        {
            PersonSequencer.reset();
            //Arrange
            //TodoSeqencer Idcounter = new TodoSeqencer();
            //Act
            int newid = PersonSequencer.nextPersonID();
            
            newid = PersonSequencer.nextPersonID();
            //Assert
            Assert.Equal(2, newid);
        }
        [Fact]
        public void TryToResetID()
        {
            //Arrange
            //TodoSeqencer Idcounter = new TodoSeqencer();
            //Act
            int newid = PersonSequencer.nextPersonID();
            newid = PersonSequencer.nextPersonID();
            PersonSequencer.reset();
            newid = PersonSequencer.nextPersonID();
            //Assert
            Assert.Equal(1, newid);
        }
        [Fact]
        public void TryToResetIDAddNew()
        {
            //Arrange
            //TodoSeqencer Idcounter = new TodoSeqencer();
            //Act
            int newid = PersonSequencer.nextPersonID();
            newid = PersonSequencer.nextPersonID();
            PersonSequencer.reset();
            newid = PersonSequencer.nextPersonID();
            newid = PersonSequencer.nextPersonID();
            newid = PersonSequencer.nextPersonID();
            newid = PersonSequencer.nextPersonID();
            //Assert
            Assert.Equal(4, newid);
        }
        [Fact]
        public void ResetReset()
        {
           
            int newid = PersonSequencer.nextPersonID();
            newid = PersonSequencer.nextPersonID();
            PersonSequencer.reset();
            PersonSequencer.reset();
            newid = PersonSequencer.nextPersonID();
            //Assert
            Assert.Equal(1, newid);
        }
    }
}
