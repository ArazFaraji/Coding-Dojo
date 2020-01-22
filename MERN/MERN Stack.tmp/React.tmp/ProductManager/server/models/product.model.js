const mongoose = require('mongoose');

const ProductSchema = new mongoose.Schema({
    title: { 
        type: String,
        required: [true, "Title is required"],
        minlength: [2, "Title must be at least two characters"] 
    },
    price: { 
        type: Number,
        required: [true, "Price is required"],
        min: [0, "Price can't be less than free"]
    },
    description: { 
        type: String,
        required: [true, "Description is required"],
        minlength: [5, "Description has to be at least 5 characters"]
        
    }

}, { timestamps: true});


module.exports.Product = mongoose.model('Product', ProductSchema);