import Image from "next/image";

export default function Footer() {
  return (
    <footer className="bg-white text-black p-6 border-t mt-10">
      <div className="container mx-auto grid grid-cols-1 md:grid-cols-5 gap-6 text-sm">
        
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

      {/* Separator */}
      <div className="border-t my-6"></div>

      {/* Logo and Legal Section */}
      <div className="container mx-auto flex flex-col md:flex-row justify-between items-center text-xs">
        {/* Logo */}
        <div className="flex items-center space-x-2">
          <Image src="/sensormatic-logo.png" alt="Sensormatic Logo" width={180} height={50} />
        </div>

        {/* Copyright Text */}
        <p className="mt-2 md:mt-0">© 2025 Johnson Controls. All Rights Reserved.</p>

        {/* Legal Links */}
        <div className="mt-2 md:mt-0 flex space-x-4">
          <a href="#" className="text-blue-600">Legal</a> |
          <a href="#" className="text-blue-600">Privacy Settings</a> |
          <a href="#" className="text-blue-600">Technical Terms</a> |
          <a href="#" className="text-blue-600">Cookie Preferences</a>
        </div>

        {/* Social Icons */}
        <div className="flex space-x-3 mt-2 md:mt-0">
          <Image src="/linkedin.svg" alt="LinkedIn" width={20} height={20} />
          <Image src="/twitter.svg" alt="Twitter" width={20} height={20} />
          <Image src="/youtube.svg" alt="YouTube" width={20} height={20} />
        </div>
      </div>
    </footer>
  );
}
