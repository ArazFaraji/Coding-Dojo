import React, { useEffect, useState } from 'react';
import Axios from 'axios';
import { Link } from '@reach/router';



export default props => {
    const [products, setProducts] = useState([]);
    useEffect( () => {
        Axios.get("http://localhost:8000/api/products")
            .then(res => setProducts(res.data))
            .catch(err => console.log(err));
    }, []);
    return(
        <div className="container">
            <h3>Product List</h3>
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
                                <td>{product.price}</td>
                                <td>{product.description}</td>
                                <td>
                                    <Link to={`/edit/${product._id}`} className="" >Edit</Link>
                                </td>
                                
                            </tr>
                        )
                    }
                </tbody>
            </table>
        </div>
    )
}