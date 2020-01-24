import React, { useEffect, useState } from 'react';
import Axios from 'axios';
import { Link } from '@reach/router';



export default props => {

    const getEverything = () => {
        Axios.get("http://localhost:8000/api/products")
            .then(res => setProducts(res.data))
            .catch(err => console.log(err));
    };

    const [products, setProducts] = useState([]);
    useEffect( () => {
        getEverything();
    }, []);

    const deleteObject = (_id) => {
        Axios.delete(`http://localhost:8000/api/product/${_id}`)
            .then(res => {
                console.log(res)
                getEverything()
            })
            .catch(err => console.log(err))
    }
    





    return(
        <div className="container">
            <h3>Ninjas!</h3>
            <table className="table table-hover table-striped">
                <tbody>
                    <tr>
                        <th>Title</th>
                        <th>Price</th>
                        <th>Description</th>
                        <th>Actions</th>
                    </tr>
                    {
                        products.map( product =>
                            <tr key={product._id}>
                                <td><Link to={`/product/${product._id}`}>{product.title}</Link></td>
                                <td>${product.price}</td>
                                <td>{product.description}</td>
                                <td>
                                    <Link to={`/edit/${product._id}`} className="btn-link" >Edit</Link>
                                    <button onClick={ e => {deleteObject(product._id)}} className="btn btn-link align-baseline">
                                        Delete
                                    </button>
                                </td>
                                
                            </tr>
                        )
                    }
                </tbody>
            </table>
        </div>
    )
}