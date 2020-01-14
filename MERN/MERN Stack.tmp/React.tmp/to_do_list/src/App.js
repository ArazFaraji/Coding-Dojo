import React, { useState } from 'react';
import './App.css';
import Task from './Components/TaskForm'
import ToDoList from './Components/ToDoList';
import TaskApp from './Components/TaskApp';

function App() {

  // const [ state, setState ] = useState ({
  //   tasks: []
  // });

  // const taskAdded = task => {
  //   console.log("Task was added to the list from the form", task);
  //   setState({tasks : [...state.tasks, task]});

  // }
  return (
    <>

    {/* <Task addTaskToList={taskAdded}/>
    <hr />
    <ToDoList items= {state.tasks}/> */}


    <TaskApp />

    </>
  );
}



// function App() {
//   const [ state, setState ] = useState({
//     tasks: []
//   });

//   const taskAdded = task => 
//   {
//     console.log("task was created in the form", task);
//     setState({tasks : [...state.tasks, task]})
//   }
//   return (
//     <>
//     <h1>To Do List</h1>
//       <Todolist tasks ={state.tasks} />
//       <Task addTask={taskAdded}  />
      


//     </>
//   );
// }

export default App;
