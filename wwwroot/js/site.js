// Press Enter to submit search form
document.addEventListener("DOMContentLoaded", function () {
    const searchInput = document.querySelector('input[name="name"]');
    if (searchInput) {
        searchInput.addEventListener("keypress", function (e) {
            if (e.key === "Enter") {
                e.preventDefault();
                this.form.submit();
            }
        });
    }

    // Confirm before delete
    document.addEventListener("DOMContentLoaded", function () {
        const deleteBtn = document.getElementById("confirmDeleteBtn");
        if (deleteBtn) {
            deleteBtn.addEventListener("click", function (e) {
                const confirmed = confirm("Are you absolutely sure you want to delete this student?");
                if (!confirmed) {
                    e.preventDefault();
                }
            });
        }
    });

    // Highlight row on hover (optional if not using Bootstrap hover)
    const rows = document.querySelectorAll("table tbody tr");
    rows.forEach(row => {
        row.addEventListener("mouseenter", () => {
            row.style.backgroundColor = "#e9ecef";
        });
        row.addEventListener("mouseleave", () => {
            row.style.backgroundColor = "";
        });
    });
});


    
