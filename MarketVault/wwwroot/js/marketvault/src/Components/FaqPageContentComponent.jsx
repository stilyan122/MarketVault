﻿class FaqPageContentComponent extends React.Component {
    render() {
        return (
            <div class="FAQPageContainer">
                <h2 class="FAQPageTitle">Help center in MarketVault</h2>
                <section>
                    <button class="accordion">What is MarketVault?</button>
                    <div class="panel">
                        <p>
                            MarketVault is a comprehensive storage and
                            management system designed to streamline operations
                            related to products, firms, counter parties, banks,
                            and item groups. It serves as a centralized platform
                            for businesses to efficiently organize, track, and access
                            important data and assets. MarketVault empowers users with
                            tools to optimize inventory management, streamline transactions,
                            and enhance collaboration across various departments.
                            With its user-friendly interface and robust features,
                            MarketVault facilitates seamless workflow management,
                            helping businesses achieve greater efficiency and
                            productivity in their operations.
                        </p>
                    </div>
                    <button class="accordion">What security measures does MarketVault employ to protect sensitive data?</button>
                    <div class="panel">
                        <p>
                            MarketVault prioritizes data security and employs robust
                            encryption protocols, access controls, and authentication
                            mechanisms to safeguard sensitive information.
                            Regular security audits and updates are conducted
                            to ensure compliance with industry standards and regulations.
                        </p>
                    </div>
                    <button class="accordion">Is MarketVault compliant with industry regulations such as GDPR?</button>
                    <div class="panel">
                        <p>
                            Yes, MarketVault prioritizes compliance with industry regulations and
                            data protection laws such as GDPR (General Data Protection Regulation).
                            The platform incorporates features and security measures to ensure
                            adherence to regulatory requirements and protect user privacy and
                            confidentiality.
                        </p>
                    </div>
                    <button class="accordion">How do you add a new product to the MarketVault system?</button>
                    <div class="panel">
                        <p>
                            To add a new product, navigate to the "Nomenclatures" section in the
                            MarketVault header and click on the "Add Product" button.
                            Then, fill in the required fields such as product name, description, prices, etc.
                            and click "Add Product" to create the new product.
                        </p>
                    </div>
                    <button class="accordion">What methods are available to search for and view product information?</button>
                    <div class="panel">
                        <p>
                            Users can search for products using the search bar or
                            browse through the list of products. Additionally, filters
                            are available to refine the product
                            list based on specific criteria such as category or cash register name.
                        </p>
                    </div>
                    <button class="accordion">How can you modify the details of an existing product, such as its name,
                        description, prices and etc.?</button>
                    <div class="panel">
                        <p>
                            To update a product, locate the desired product in the product
                            list and click on the "Edit" button. This will open a
                            form where users can make changes to the product details.
                            After making the necessary modifications, click "Edit Product" to update the product.
                        </p>
                    </div>
                    <button class="accordion">
                        What steps are involved in removing a product from the MarketVault database?
                    </button>
                    <div class="panel">
                        <p>
                            To delete a product, select the product from the product list and click on the "Delete" button.
                            Users will be prompted to confirm the deletion, and upon confirmation, the product will be
                            removed from the database.
                        </p>
                    </div>
                    <button class="accordion">
                        Are the previous steps the same as of adding/edditing/deleting/etc. an address/firm/bank/etc.?
                    </button>
                    <div class="panel">
                        <p>
                            Yes! To add/edit/delete/etc. a firm/address/bank/etc.
                            you should follow the same steps as with the products.
                        </p>
                    </div>
                    <footer class="FAQPageFooter">
                        We hope this FAQ section has provided
                        valuable insights into our platform.
                        Should you require additional information or clarification,
                        feel free to reach out to us.
                    </footer>
                </section>
            </div>
        );
    }
}
