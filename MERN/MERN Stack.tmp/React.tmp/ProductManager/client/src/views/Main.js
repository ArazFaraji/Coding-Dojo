import React, {useEffect, useState } from 'react';
import axios from 'axios';

import ProductForm from '../components/ProductForm';

export default () => {
    return (
        <div>
            <ProductForm />
        </div>
    )










    // const [ message, setMessage ] = useState("Loading...")
    // useEffect ( () => {
    //     axios.get("http://localhost:8000/api")
    //         .then(res => setMessage(res.data.message))
    // }, []);

    // return (
    //     <div>
    //         <h2>Message from the backend: { message }</h2>
    //     </div>
    // )
}