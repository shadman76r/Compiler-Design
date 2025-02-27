const Footer = () => {
    return (
      <footer className="bg-white text-black p-6 mt-10 border-t">
        <div className="container mx-auto grid grid-cols-2 md:grid-cols-4 gap-6 text-sm">
          
          {/* Connect Section */}
          <div>
            <h3 className="font-bold">CONNECT</h3>
            <p className="mt-2 text-lg font-bold">+1 800-642-7505 (US)</p>
            <p>Sales and general inquiries</p>
            <button className="mt-3 border px-4 py-2">Contact Us</button>
          </div>
  
          {/* Buy Sensormatic */}
          <div>
            <h3 className="font-bold">BUY SENSORMATIC</h3>
            <a href="#" className="text-blue-600 mt-2 block">Download Our Catalog</a>
          </div>
  
          {/* Press */}
          <div>
            <h3 className="font-bold">PRESS</h3>
            <a href="#" className="text-blue-600 mt-2 block">Media Center</a>
          </div>
  
          {/* Get Help */}
          <div>
            <h3 className="font-bold">GET HELP</h3>
            <a href="#" className="text-blue-600 mt-2 block">Support and Service</a>
          </div>
  
          {/* Join Us */}
          <div>
            <h3 className="font-bold">JOIN US</h3>
            <a href="#" className="text-blue-600 mt-2 block">Careers</a>
            <a href="#" className="text-blue-600 mt-2 block">Subscribe to Retail Insights</a>
          </div>
  
          {/* Customer Login */}
          <div>
            <h3 className="font-bold">CUSTOMER LOGIN</h3>
            <a href="#" className="text-blue-600 mt-2 block">ShopperTrak Analytics Login</a>
          </div>
  
        </div>
  
        {/* Logo and Legal Section */}
        <div className="mt-6 border-t pt-4 text-center text-xs">
          <p className="text-blue-600 text-lg font-bold">Sensormatic by Johnson Controls</p>
          <p>© 2025 Johnson Controls. All Rights Reserved.</p>
          <div className="mt-2">
            <a href="#" className="mx-2">Legal</a> |
            <a href="#" className="mx-2">Privacy Settings</a> |
            <a href="#" className="mx-2">Technical Terms</a> |
            <a href="#" className="mx-2">Cookie Preferences</a>
          </div>
        </div>
      </footer>
    );
  };
  
  export default Footer;
  