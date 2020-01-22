import React, { useState } from 'react';
import axios from 'axios';

export default () => {
    const [ title, setTitle ] = useState("");
    const [ price, setPrice ] = useState(0);
    const [ description, setDescription ] = useState("");

    const onSubmitHandler = e => {
        e.preventDefault();
        axios.post('http://localhost:8000/api/product', {
            title,
            price,
            description
        })
            .then(res => console.log(res))
            .catch(err => console.log(err))
    }

    return (
        <div className="container">
            <h2>Submit your product</h2>
            <form onSubmit={onSubmitHandler}>
                <div className="form-group">
                    <label htmlFor="">Title</label>
                    <input type="text" onChange={ e => setTitle(e.target.value)} className="form-control" />
                </div>
                <div className="form-group">
                    <label htmlFor="">Price</label>
                    <input type="text" onChange={ e => setPrice(e.target.value)} className="form-control" />
                </div>
                <div className="form-group">
                    <label htmlFor="">Description</label>
                    <input type="text" onChange={ e => setDescription(e.target.value)} className="form-control" />
                </div>
                <input type="submit" value="submit"/>
            </form>
        </div>
    )
}