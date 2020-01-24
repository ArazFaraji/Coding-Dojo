import React, { useState, useEffect } from 'react';
import axios from 'axios';
import { navigate } from '@reach/router';

export default props => {
    const [ title, setTitle ] = useState("");
    const [ price, setPrice ] = useState(0);
    const [ description, setDescription ] = useState("");
    
    const [errors, setErrors] = useState({});

    useEffect( () => {
        axios.get(`http://localhost:8000/api/product/${props._id}`)
            .then(res => {
                setTitle(res.data.title);
                setPrice(res.data.price);
                setDescription(res.data.description);
                console.log(res.data)
            })
            .catch(err => console.log(err))
    }, [props._id])

    const onSubmitHandler = e => {
        e.preventDefault();
        axios.put(`http://localhost:8000/api/product/${props._id}`, {
            title,
            price,
            description
        })
            .then(res => {
                if(res.data.errors) {
                    setErrors(res.data.errors);
                }
                else {
                    navigate("/")
                }
                console.log(res)
                
            })
            .catch(err => console.log(err))
    }

    return (
        <div className="container">
            <h2>Submit your product</h2>
            <form onSubmit={onSubmitHandler}>
                <div className="form-group">
                    <label htmlFor="">Title</label>
                    <input type="text" step="0.01" onChange={ e => setTitle(e.target.value)} className="form-control" value={title} />
                    <span className="text-danger">{errors.title ? errors.title.message: "" }</span>
                </div>
                <div className="form-group">
                    <label htmlFor="">Price</label>
                    <input type="number" onChange={ e => setPrice(e.target.value)} className="form-control" value={price} />
                    <span className="text-danger">{errors.price ? errors.price.message: "" }</span>
                </div>
                <div className="form-group">
                    <label htmlFor="">Description</label>
                    <input type="text" onChange={ e => setDescription(e.target.value)} className="form-control" value={description} />
                    <span className="text-danger">{errors.description ? errors.description.message: "" }</span>
                </div>
                <input type="submit" value="submit"/>
            </form>
        </div>
    )
}