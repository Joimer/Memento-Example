"use strict";

// List of stored past states.
let storedStates = [];

// This is the class that does stuff and has internal state.
let originator = new Originator();
originator.setState('State1');
originator.setState('State2');

// Memento a state.
storedStates.push(originator.saveToMemento());

// New state
originator.setState('State3');

// We can request multiple mementos, and choose which one to roll back to.
storedStates.push(originator.saveToMemento());

// Yet another state
originator.setState('State4');

// Oh shit we need the past state
originator.restoreFromMemento(savedStates.unshift());

console.log(originator.state);
// Output: 'State3'
