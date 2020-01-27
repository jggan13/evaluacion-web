import React, {Fragment} from 'react';

function Product({producto}){

    const {Id, Codigo, Descripcion, PrecioVenta, Cantidad, Total} = producto;

    return(
        <Fragment>
            <tr>
                <td>{Id}</td>
                <td>{Codigo}</td>
                <td>{Descripcion}</td>
                <td>{PrecioVenta}</td>
                <td>{Cantidad}</td>
                <td>{Total}</td>
            </tr>
        </Fragment>
    )
}

export default Product;