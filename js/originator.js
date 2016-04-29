"use strict";

const Memento = require('./memento.js');

class Originator {
	constructor() {
		this.state;
	}

	setState(state) {
		this.state = state;
	}

	saveToMemento() {
		return new Memento(this.state);
	}

	restoreFromMemento(memento) {
		this.state = memento.getSavedState();
		console.log('State restored from Memento.');
	}
}

module.exports = Originator;
