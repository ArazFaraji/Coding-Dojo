import React, { useState } from 'react';

const TaskForm = props => {
    // const [ listState, setListState ] = useState({
    //     task: "",
    //     items: [],
    // });

    // const onChange = event => {
    //     event.preventDefault();
    //     setListState({
    //         ...listState,
    //         [event.target.name] : event.target.value
    //     })
    // }

    // const onSubmitHandler = event => {
    //     event.preventDefault();
    //     props.addTaskToList(listState);
        
    //     setListState({
    //         items: [...listState.items, 
    //             {
    //                 text: listState.task,
    //                 isCompleted: false
    //             }],
    //         task: "",
    //     });
    //     console.log(listState);
    // }

    const [task, setTask] = useState("");
    const [isCompleted, setIsCompleted] = useState(false);

    const addTaskToList = e => {
        e.preventDefault();
        props.addTask();
        setTask("");
        isCompleted(false);
        
    };

    return (
        <>
            <div className="container">
                <h1>Start adding tasks!</h1>
                <form onSubmit={addTaskToList}>
                    <div className="form-group">
                        <label>Task</label>
                        <input 
                            type="text" 
                            value={task} 
                            className="form-control" 
                            name="task" 
                            onChange={e => setTask(e.target.value)} 
                        />
                    </div>

                    <div className="form-group">
                        <input type="submit" className="btn btn-primary" />
                    </div>
                    

                </form>
            </div>
        </>
    );
}

export default TaskForm


// import React, { useState } from 'react';

// const Task = props => {
    
//     const [state, setState] = useState({
//         name: "",
//         completed: false
//     });


          
   
//     const changeName = e =>{
//             e.preventDefault();
//             console.log(e.target.value);
//             setState({...state, name: e.target.value});
//         }

//     const addTask = e => {
//          e.preventDefault();
            
//                 props.addTask(state);
//                 setState({
//                     name: "",
//                     completed: false
                    
                  
        
//                 });
                
//             }
   

//         return (
//             <>
//             <div className="container">
//                 <form onSubmit={addTask}>
//                     <div className="form-group">
//                         <label>Name:</label>
//                         <input
//                             type="text"
//                             className="form-control"
//                             onChange={changeName}
//                             value = {props.name}
                            
    
//                         />
//                         <input type = "submit" />
                    
//                     </div>
                    
//                 </form>
//                 </div>
           
//             </>
//         );
// }

// export default Task;