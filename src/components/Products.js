import React, { useState, useEffect } from 'react';
import axios from 'axios';
import Product from './Product';

function Products(){

    const [productos, setProductos] = useState([]);


    useEffect(() => {
        let url = `http://localhost:61408/api/values`;  
        
        const getValues = async () => {
        await axios.get(url)
        .then(response => {
            console.log(response.data);
            setProductos(response.data);
        })
        .catch(error => {
            console.log(error);
        }); 
    }

    getValues();

    },[])

    return(
        <React.Fragment>

<div className="container">
    <h1 className="text-center mt-5">Listado de Productos</h1>
        <table className="table table-striped mt-5" id='productos'>
            <thead>
            <tr>
            <th>Id</th>
            <th >Código</th>
            <th>Descripción</th>
            <th >Precio de venta</th>
            <th>Cantidad</th>
            <th >Total</th>
            </tr>
            </thead>
               <tbody>
                  
            {
                productos.map((producto, indice) => (
                        <Product key={producto.Id} producto={producto}/>
                    ))
            }
             </tbody>
            </table>
            </div>
        </React.Fragment>
    )
}

export default Products;