// Import global CSS and Footer component
import "./globals.css";
import Footer from "./components/Footer"; // Make sure the Footer path is correct
import CustomerLogos from "./components/CustomerLogos";


// Define the RootLayout component that wraps around all other components
export default function RootLayout({
  children,
}: {
  children: React.ReactNode;
}) {
  return (
    <html lang="en">
      <body>
        {/* Render children (the content of each page) */}
        {children}

        {/* Footer component is included at the bottom of every page */}
        <Footer />
      </body>
    </html>
  );
}
