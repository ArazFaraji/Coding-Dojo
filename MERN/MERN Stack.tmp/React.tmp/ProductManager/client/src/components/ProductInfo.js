import React, { useEffect, useState } from 'react';
import axios from 'axios';


export default props => {
    const [product, setProduct] = useState({})
    useEffect( () => {
        axios.get("http://localhost:8000/api/product/" + props._id)
        .then(response => {
            setProduct(response.data)
            console.log(response)
        })
        .catch(err => console.log("Error:", err))
        
    }, [props._id])

    return (
        <div className="container">
            <h3>{product.title}</h3>
            <p>${product.price}</p>
            <p>{product.description}</p>
        </div>

    )
}