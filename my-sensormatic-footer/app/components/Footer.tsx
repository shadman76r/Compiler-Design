import Image from "next/image";

export default function Footer() {
  return (
    <>
      <section className="my-12 text-center">
        <h2 className="text-xl font-semibold mb-4">Our customers include:</h2>
        <div className="flex justify-center items-center space-x-12 flex-wrap">
          <div className="w-32 h-32 flex items-center justify-center">
            <Image src="/images/rayban-logo.png" alt="RayBan" width={120} height={50} />
          </div>
          <div className="w-32 h-32 flex items-center justify-center">
            <Image src="/images/adidas-logo.png" alt="Adidas" width={120} height={50} />
          </div>
          <div className="w-32 h-32 flex items-center justify-center">
            <Image src="/images/mango-logo.png" alt="Mango" width={120} height={50} />
          </div>
          <div className="w-32 h-32 flex items-center justify-center">
            <Image src="/images/tmobile-logo.png" alt="T-Mobile" width={120} height={50} />
          </div>
          <div className="w-32 h-32 flex items-center justify-center">
            <Image src="/images/kroger-logo.png" alt="Kroger" width={120} height={50} />
          </div>
          <div className="w-32 h-32 flex items-center justify-center">
            <Image src="/images/boots-logo.png" alt="Boots" width={120} height={50} />
          </div>
          <div className="w-32 h-32 flex items-center justify-center">
            <Image src="/images/levis-logo.png" alt="Levis" width={120} height={50} />
          </div>
          <div className="w-32 h-32 flex items-center justify-center">
            <Image src="../../pictures/puma-logo-png_seeklogo-113793.png" alt="Puma" width={120} height={50} />
          </div>
          <div className="w-32 h-32 flex items-center justify-center">
            <Image src="/images/claires-logo.png" alt="Claire's" width={120} height={50} />
          </div>
        </div>
      </section>

      <footer className="bg-white text-black p-6 border-t mt-10">
        <div className="container mx-auto grid grid-cols-1 md:grid-cols-5 gap-6 text-sm">
          {/* Other sections */}
          <div>
            <h3 className="font-bold">CONNECT</h3>
            <p className="mt-2 text-lg font-bold">+1 800-642-7505 (US)</p>
            <p>Sales and general inquiries</p>
            <button className="text-blue-600 mt-4 border px-4 py-2">Contact Us</button>
          </div>
          <div>
            <h3 className="font-bold">BUY SENSORMATIC</h3>
            <a href="#" className="text-blue-600 mt-2 block">Download Our Catalog</a>
          </div>
          <div>
            <h3 className="font-bold">PRESS</h3>
            <a href="#" className="text-blue-600 mt-2 block">Media Center</a>
          </div>
          <div>
            <h3 className="font-bold">GET HELP</h3>
            <a href="#" className="text-blue-600 mt-2 block">Support and Service</a>
          </div>
          <div>
            <h3 className="font-bold">JOIN US</h3>
            <a href="#" className="text-blue-600 mt-2 block">Careers</a>
            <a href="#" className="text-blue-600 mt-2 block">Subscribe to Retail Insights</a>
          </div>
          <div>
            <h3 className="font-bold">CUSTOMER LOGIN</h3>
            <a href="#" className="text-blue-600 mt-2 block">ShopperTrak Analytics Login</a>
          </div>
        </div>

        {/* Separator */}
        <div className="border-t my-6"></div>

        {/* Footer Bottom Section */}
        <div className="container mx-auto flex flex-col items-center md:flex-row justify-between text-xs text-center md:text-left">
          <div className="flex flex-col items-center space-y-4">
            {/* Sensormatic Branding Text */}
            <div className="flex items-center space-x-1">
              <span className="font-bold text-blue-600">Sensormatic by Johnson Controls</span>
            </div>

            {/* Copyright Text */}
            <p className="text-gray-600">© 2025 Johnson Controls. All Rights Reserved.</p>

            {/* Legal Links */}
            <div className="flex space-x-4 text-blue-600">
              <a href="#">Legal</a>
              <a href="#">Privacy Settings</a>
              <a href="#">Technical Terms</a>
              <a href="#">Cookie Preferences</a>
            </div>
          </div>
        </div>
      </footer>
    </>
  );
}
