import React, { useState } from 'react';

const ToDoList = props => {

    //  const tasks = props.items.map((item, index) => 
    //         <li key={index}>{item}</li>)

    // const [ state, setState ] = useState({
    //     tasks: props.items,
    //     isCompleted : false
    // })

    // const CheckboxHandler = event => {
    //     event.preventDefault();

    // }

    // return(
    //     <>
    //         <h2>List of Tasks!</h2>
    //         <ul>
    //             {/* {tasks.items} */}
    //             {
    //                 props.items.map( (item, index) => 
    //                     <li key={index}>
    //                         {item.task} <input type="checkbox" />
    //                     </li>)
    //             }
    //         </ul>
    //     </>
    // )


    const removeTask = i => {
        props.removeTask(i);
    }

    const editTask = i => {
        props.editTask(i);
    }

    return(
            <>
                <h2>List of Tasks!</h2>
                <ul>
                    {/* {tasks.items} */}
                    {
                        props.tasks.map( (task, index) => 
                            <li key={index}>
                                {task.task} <input type="checkbox" />
                            </li>)
                    }
                </ul>
            </>
        )
};

export default ToDoList;

// import React, { useState } from 'react';


// const Todolist = props =>
// {
//     return (
//         <>
//         <div className="container">
//             <h2>Tasks</h2>
//             <ul>
//                 {
                    
//                     props.tasks.map ((task, i) =>
                        
//                             <li key = {i}>{task.name}<input type="checkbox"></input><button>Remove</button></li>
                        
//                     )
//                 }
//             </ul>
          
//         </div>
//         </>

//     );
// }
// export default Todolist;