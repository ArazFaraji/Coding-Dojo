import React from 'react';

import ProductForm from '../components/ProductForm';
import ProductList from '../components/ProductList';
import ProductInfo from '../components/ProductInfo';
import EditProductForm from '../components/EditProductForm';
import { Router, Link } from '@reach/router';

export default () => {
    return (
        <>
            <div className="container">
            <Link to="/">Home</Link> | 
            <Link to="/new"> Add your product</Link>
            </div>


            <Router>
                <ProductForm path="/new" />
                <ProductList path="/" />
                <ProductInfo path="/product/:_id" />
                <EditProductForm path="/edit/:_id" />
            </Router>
        </>
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