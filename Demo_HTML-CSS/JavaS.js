
let customers = [];
let orders = [];

function register() {
    const username = document.getElementById("username").value;
    const password = document.getElementById("password").value;
    const fullName = document.getElementById("fullName").value;
    const email = document.getElementById("email").value;
  
    // TODO Perform registration logic (e.g., validate inputs, create user in database)
  

  // Create a new customer object
    const newCustomer = {
    username: username,
    fullName: fullName,
    email: email
  };

  // Add the new customer to the customers array
  customers.push(newCustomer);

    // Clear form fields after registration
    document.getElementById("username").value = "";
    document.getElementById("password").value = "";
    document.getElementById("fullName").value = "";
    document.getElementById("email").value = "";
  
    // Show a success message or redirect to another page
    alert("Registration successful!");
     //TODO Hide Register section and display Login section
     document.getElementById("registrationSection").style.display = "none";
     document.getElementById("loginSection").style.display = "block";
  }
  
  let loggedInUser = null;
  let selectedStore = null;
  let cart = [];
  
  function login() {
    const username = document.getElementById("username").value;
    const password = document.getElementById("password").value;
  
    // Perform login validation (e.g., check against user database)
  
    // For demonstration purposes, we'll assume successful login
    loggedInUser = username;
  
    // Hide login section and display store selection section
    document.getElementById("loginSection").style.display = "none";
    document.getElementById("storeSection").style.display = "block";
  }
   
  function placeOrder() {
  const customerName = document.getElementById("customerName").value;
  const storeLocation = document.getElementById("storeLocation").value;
  const product = document.getElementById("product").value;
  const quantity = document.getElementById("quantity").value;

  // Perform order placement logic (e.g., validate inputs, create order in database)

  // Create a new order object
  const newOrder = {
    customerName: customerName,
    storeLocation: storeLocation,
    product: product,
    quantity: quantity
  };
  // Add the new order to the orders array
  orders.push(newOrder);

  // Clear form fields after placing the order
  document.getElementById("customerName").value = "";
  document.getElementById("storeLocation").value = "";
  document.getElementById("product").value = "";
  document.getElementById("quantity").value = "";

  // Show a success message or perform other actions
  alert("Order placed successfully!");
}
function addCustomer() {
    const newCustomerName = document.getElementById("newCustomerName").value;
    const newCustomerEmail = document.getElementById("newCustomerEmail").value;
  
    // Perform customer addition logic (e.g., validate inputs, add customer to database)
  
    // Create a new customer object
    const newCustomer = {
      fullName: newCustomerName,
      email: newCustomerEmail
    };
  
    // Add the new customer to the customers array
    customers.push(newCustomer);
    // Clear form fields after adding the customer
  document.getElementById("newCustomerName").value = "";
  document.getElementById("newCustomerEmail").value = "";

  // Show a success message or perform other actions
  alert("Customer added successfully!");
}
function searchCustomer() {
    const searchCustomerName = document.getElementById("searchCustomerName").value;
  
    // Perform customer search logic (e.g., search in the database)
  
    // Find the customer with the matching name
    const foundCustomer = customers.find(customer => customer.fullName === searchCustomerName);
  
    if (foundCustomer) {
      // Display customer details
      alert(`Customer found!\nName: ${foundCustomer.fullName}\nEmail: ${foundCustomer.email}`);
    } else {
      alert("Customer not found!");
    }
  
    // Clear the search field
    document.getElementById("searchCustomerName").value = "";
  }

// data for products and order history
const productsData = {
    store1: [
      { id: 1, name: "Product 1", price: 10 },
      { id: 2, name: "Product 2", price: 20 },
      { id: 3, name: "Product 3", price: 30 }
    ],
    store2: [
      { id: 4, name: "Product 4", price: 15 },
      { id: 5, name: "Product 5", price: 25 },
      { id: 6, name: "Product 6", price: 35 }
    ],
    store3: [
      { id: 7, name: "Product 7", price: 12 },
      { id: 8, name: "Product 8", price: 22 },
      { id: 9, name: "Product 9", price: 32 }
    ]
  };
  
  const orderHistoryData = {
    store1: [
      { id: 1, product: "Product 1", quantity: 2 },
      { id: 2, product: "Product 2", quantity: 1 },
      { id: 3, product: "Product 3", quantity: 3 }
    ],
    store2: [
      { id: 4, product: "Product 4", quantity: 1 },
      { id: 5, product: "Product 5", quantity: 2 },
      { id: 6, product: "Product 6", quantity: 2 }
    ],
    store3: [
      { id: 7, product: "Product 7", quantity: 3 },
      { id: 8, product: "Product 8", quantity: 2 },
      { id: 9, product: "Product 9", quantity: 1 }
    ]
  };
  

  
  function showProducts() {
    selectedStore = document.getElementById("storeSelect").value;
  
    // Clear previous products
    document.getElementById("productList").innerHTML = "";
  
    // Display products of selected store
    productsData[selectedStore].forEach(product => {
      const productItem = document.createElement("div");
      productItem.className = "productItem";
      productItem.innerHTML = `<h3>${product.name}</h3><p>Price: $${product.price}</p>
                               <input type="number" min="1" value="1" id="quantity_${product.id}">
                               <button onclick="addToCart(${product.id})">Add to Cart</button>`;
      document.getElementById("productList").appendChild(productItem);
    });
  
    // Hide store section and display product section
    document.getElementById("storeSection").style.display = "none";
    document.getElementById("productSection").style.display = "block";
  }
  
  function addToCart(productId) {
    const quantity = parseInt(document.getElementById(`quantity_${productId}`).value);
  
    // Find the product in the productsData
    const selectedProduct = productsData[selectedStore].find(product => product.id === productId);
  
    // Create cart item object
    const cartItem = {
      store: selectedStore,
      product: selectedProduct,
      quantity: quantity
    };
  
    // Add cart item to the cart
    cart.push(cartItem);
  
    // Update cart section
    updateCartSection();
  }
  
  function updateCartSection() {
    const cartItemsDiv = document.getElementById("cartItems");
  
    // Clear previous cart items
    cartItemsDiv.innerHTML = "";
  
    // Display current cart items
    cart.forEach(item => {
      const cartItemDiv = document.createElement("div");
      cartItemDiv.innerHTML = `<p><strong>${item.product.name}</strong> - $${item.product.price} x ${item.quantity}</p>`;
      cartItemsDiv.appendChild(cartItemDiv);
    });
  
    // Hide product section and display cart section
    document.getElementById("productSection").style.display = "none";
    document.getElementById("cartSection").style.display = "block";
  }
  
  function checkout() {
    // Perform checkout logic (e.g., update database, generate order)
  
    // Clear the cart
    cart = [];
  
    // Update cart section
    updateCartSection();
  
    // Show order history section
    showOrderHistory();
  }
  
  function showOrderHistory() {
    const selectedStore = document.getElementById("orderHistorySelect").value;
    const orderHistoryDiv = document.getElementById("orderHistory");
  
    // Clear previous order history
    orderHistoryDiv.innerHTML = "";
  
    // Display order history of the selected store
    orderHistoryData[selectedStore].forEach(order => {
      const orderDiv = document.createElement("div");
      orderDiv.innerHTML = `<p><strong>${order.product}</strong> - Quantity: ${order.quantity}</p>`;
      orderHistoryDiv.appendChild(orderDiv);
    });
  
    // Hide other sections and display order history section
    document.getElementById("storeSection").style.display = "none";
    document.getElementById("productSection").style.display = "none";
    document.getElementById("cartSection").style.display = "none";
    document.getElementById("orderHistorySection").style.display = "block";
  }
  

  function displayOrderHistory() {
    const customerOrderHistory = document.getElementById("customerOrderHistory").value;
  
    // Perform order history retrieval logic (e.g., fetch order history from the database)
  
    // Filter the orders array to find orders placed by the specified customer
    const customerOrders = orders.filter(order => order.customerName === customerOrderHistory);
  
    if (customerOrders.length > 0) {
      // Display order history
      const orderHistoryDiv = document.getElementById("orderHistory");
      orderHistoryDiv.innerHTML = ""; // Clear previous order history
  
      customerOrders.forEach(order => {
        const orderDetails = document.createElement("p");
        orderDetails.innerHTML = `<strong>Store Location:</strong> ${order.storeLocation}<br>
          <strong>Product:</strong> ${order.product}<br>
          <strong>Quantity:</strong> ${order.quantity}<br><br>`;
        orderHistoryDiv.appendChild(orderDetails);
    });

    } 
    else {
      alert("No order history found for the customer!");
    }
  
    // Clear the search field
    document.getElementById("customerOrderHistory").value = "";
  }
                   











// // Storing a value in session storage
// sessionStorage.setItem(age, 40);


// localStorage.setItem(age, 40 );


// // Storing a value in session storage
// sessionStorage.setItem(age, 40);
// localStorage.setItem(age, 40 );

// function formsignup(e,x) {nt
//     e.preventDefault();
//     console.log(e);
//     console.log(e.target[1].value);
// }
//let storedValue = localStorage.getItem('name');
//let storedValue = "localStorag"
// Storing a value in local storage
//localStorage.setItem( 1 , storedValue);
// Retrieving a value from local storage
//let storedValue = localStorage.getItem('name');
//console.log (storedValue);
// Removing an item from local storage
// localStorage.removeItem('name');
// // Clearing all data from local storage
//localStorage.clear();

// 