// a reducer takes in two thing:
// 1. action
// 2. copy of current state

function comments(state = [], action) {
	console.log(state, action);
	return state;
}

export default comments;