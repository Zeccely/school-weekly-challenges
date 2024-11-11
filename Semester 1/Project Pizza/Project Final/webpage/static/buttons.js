
document.addEventListener('DOMContentLoaded', function () {
    // Modal and Popover
    const exampleModal = document.getElementById('pizzaChange');
    const pizzaPaths = document.querySelectorAll('.hoverPizza');
    
    // Initialize popover for hover on each pizza path
    const popoverTriggerList = [...pizzaPaths].map(popoverTriggerEl => new bootstrap.Popover(popoverTriggerEl));
  
    if (exampleModal) {
      pizzaPaths.forEach(function (pizza) {
        // Add click event for modal trigger
        pizza.addEventListener('click', function (event) {
          // Trigger modal display
          const button = event.target;
  
          // Extract pizza details from the clicked path
          const title = button.getAttribute('data-bs-title');
          const itemid = button.getAttribute('data-bs-itemid');

          
          // Update the modal's content and added functionality for the backend bcs its late and jess is tired
          const modalTitle = exampleModal.querySelector('.ingredientsDisplay');
          modalTitle.textContent = title;

          const cartAdder = exampleModal.querySelector(".backends");
                if (cartAdder) {
                    cartAdder.value = itemid || ""; // Set the value for backend use
                }
        
  
          // Trigger the modal
          const modal = new bootstrap.Modal(exampleModal);
          modal.show();
        });
      });
    }
  });

  








