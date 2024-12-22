# KeyVaultLab

## Overview

KeyVaultLab is an ASP.NET MVC application that demonstrates how to integrate Azure Key Vault for securely managing application secrets. The project includes examples of using both managed identity and connection strings to authenticate and retrieve secrets from Azure Key Vault.


## Getting Started

### Prerequisites

- Visual Studio 2019 or later
- .NET Framework 4.8
- Azure Subscription (for Azure Key Vault)

### Setup

1. Clone the repository:
    ```sh
    git clone https://github.com/yourusername/KeyVaultLab.git
    cd KeyVaultLab
    ```

2. Open the solution in Visual Studio:
    ```sh
    KeyVaultLab.sln
    ```

3. Restore the NuGet packages:
    ```sh
    nuget restore KeyVaultLab.sln
    ```

4. Build and run the project.

## Configuration

### Web.config
Update the `Web.config` file with your Azure Key Vault and Blob Storage settings.


## Usage

- Navigate to the Home page to see the environment variables and secrets retrieved from Azure Key Vault.
- Use the About page to connect directly to Azure Key Vault and display a secret.
- Use the Contact page to query data from Azure Blob Storage using both managed identity and connection string authentication.

### HomeController

- `Index` action: Retrieves values from `Web.config`.
- `About` action: Retrieves a secret value from Azure Key Vault.
- `Contact` action: Connects to Azure Blob Storage using Managed Identity and Connection String.

### BundleConfig

Bundles and minifies JavaScript and CSS files for the project.

### AssemblyInfo

Contains general information about the assembly.

## Contributing

Contributions are welcome! Please open an issue or submit a pull request for any changes.

## License

This project is licensed under the MIT License. See the LICENSE file for details.