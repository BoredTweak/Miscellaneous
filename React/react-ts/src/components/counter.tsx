import { useReducer } from "react";

enum Action {
    None = 0,
    Increment,
    Decrement
  }  

function reducer(count: number, action: Action) {
  switch (action) {
    case Action.Increment:
      return count + 1;
    case Action.Decrement:
      return count - 1;
    default:
      throw new Error();
  }
}

export default function Counter() {
    const [count, dispatch] = useReducer(reducer, 0);
    return (
      <>
        Count: {count}
        <button onClick={() => dispatch(Action.Decrement)}>-</button>
        <button onClick={() => dispatch(Action.Increment)}>+</button>
      </>
    );
  }