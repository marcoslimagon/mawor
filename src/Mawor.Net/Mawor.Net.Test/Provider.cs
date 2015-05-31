using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mawor.Net.Implementation.InMemory.Provider;
using Mawor.Net.Implementation.InMemory;
using System.Collections.Generic;
using Mawor.Net.Interface;

namespace Mawor.Net.Test
{
    [TestClass]
    public class Provider
    {
        [TestMethod]
        public void TestFlow()
        {

            InMemoryWorkflowProvider memoryProvider = new InMemoryWorkflowProvider(new InMemoryIdentityProvider());
            var wkf = memoryProvider.CreateNewWorkflow();

            var step1 = memoryProvider.CreateNewStep();
            var step2 = memoryProvider.CreateNewStep();

            wkf.DefaultStep = step1;

            var transition1 = memoryProvider.CreateNewTransition(step1, step2);
            var transition2 = memoryProvider.CreateNewTransition(step2, step1);
            
            step1.Transitions.Add(transition1);
            step2.Transitions.Add(transition2);


            
            var currentStep = wkf.DefaultStep;




            var transitionAux = new List < ITransition < Guid >> ( currentStep.Transitions);

            Assert.AreEqual(transitionAux[0].From, step1);
            Assert.AreEqual(transitionAux[0].To, step2);

        }
    }
}
