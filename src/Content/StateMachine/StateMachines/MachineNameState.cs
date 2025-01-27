namespace Company.StateMachines
{
    using System;
    using Automatonymous;

    public class MachineNameState :
        SagaStateMachineInstance 
    {
        public int CurrentState { get; set; }

        public string Value { get; set; }

        public Guid CorrelationId { get; set; }
    }
}