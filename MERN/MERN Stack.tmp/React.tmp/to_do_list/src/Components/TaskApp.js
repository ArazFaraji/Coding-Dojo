import React, { useState } from 'react';
import TaskForm from './TaskForm';
import ToDoList from './ToDoList';
import EditTaskForm from '/.EditTaskForm';

const TaskApp = props => {

    const [taskIdToEdit, setTaskIdToEdit] = useState(-1);
    const [taskToEdit, setTaskToEdit] = useState({});
    const [tasks, setTasks] = useState([]);





    const addTask = task => {
        setTasks([...tasks, task]);
    }




    return (
        <>
            <h1>To Do List</h1>

            <TaskForm addTask={ addTask } />

            <hr />

            <NinjaTable />

        </>
    );

}


export default TaskApp;