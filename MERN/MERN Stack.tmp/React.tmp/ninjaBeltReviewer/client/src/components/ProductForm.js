import React, { useState } from 'react';
import axios from 'axios';
import { navigate } from '@reach/router';

export default () => {
    const [ title, setTitle ] = useState("");
    const [ price, setPrice ] = useState(0);
    const [ description, setDescription ] = useState("");
    
    const [errors, setErrors] = useState({});

    const onSubmitHandler = e => {
        e.preventDefault();
        axios.post('http://localhost:8000/api/product', {
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
                    <input type="text" onChange={ e => setTitle(e.target.value)} className="form-control" />
                    <span className="text-danger">{errors.title ? errors.title.message: "" }</span>
                </div>
                <div className="form-group">
                    <label htmlFor="">Price</label>
                    <input type="number" step="0.01" onChange={ e => setPrice(e.target.value)} className="form-control" />
                    <span className="text-danger">{errors.price ? errors.price.message: "" }</span>
                </div>
                <div className="form-group">
                    <label htmlFor="">Description</label>
                    <input type="text" onChange={ e => setDescription(e.target.value)} className="form-control" />
                    <span className="text-danger">{errors.description ? errors.description.message: "" }</span>
                </div>
                <input type="submit" value="submit"/>
            </form>
        </div>
    )
}