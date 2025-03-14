'use client';
import Image from "next/image";
import { useEffect, useState } from "react";
import styles from "./Footer.module.css"; // Import the CSS file for animation

export default function Footer() {
  const [isAnimationDone, setIsAnimationDone] = useState(false);

  useEffect(() => {
    setIsAnimationDone(true); // Trigger the animation once the component is mounted
  }, []);

  return (
    <>
      <section
        className={`my-12 text-center ${isAnimationDone ? styles.animateSlideFromRight : ""}`}
      >
        <h3 className="text-xl font-bold mb-10">Our customers include:</h3>
        <div className="flex flex-wrap justify-center items-center space-x-14">
          <div className="w-32 h-32 flex items-center justify-center">
            <Image src="/adidas1.svg" alt="#" width={100} height={30} />
          </div>
          <div className="w-32 h-32 flex items-center justify-center">
            <Image src="/boots-logo.svg" alt="#" width={100} height={30} />
          </div>
          <div className="w-32 h-32 flex items-center justify-center">
            <Image src="/levis-1.svg" alt="#" width={100} height={30} />
          </div>
          <div className="w-32 h-32 flex items-center justify-center">
            <Image src="/mango-4.svg" alt="#" width={100} height={30} />
          </div>
          <div className="w-32 h-32 flex items-center justify-center">
            <Image src="/puma-logo.svg" alt="#" width={100} height={30} />
          </div>
          <div className="w-32 h-32 flex items-center justify-center">
            <Image src="/t-mobile-2.svg" alt="#" width={100} height={30} />
          </div>
          <div className="w-32 h-32 flex items-center justify-center">
            <Image src="/boots.svg" alt="#" width={100} height={10} />
          </div>
          <div className="w-32 h-32 flex items-center justify-center">
            <Image src="/wilson-logo.svg" alt="#" width={100} height={10} />
          </div>
          <div className="w-32 h-32 flex items-center justify-center">
            <Image src="/claires-seeklogo.png" alt="#" width={100} height={10} />
          </div>
          <div className="w-32 h-32 flex items-center justify-center">
            <Image src="/current-kroger-logo.svg" alt="#" width={100} height={10} />
          </div>
          <div className="w-32 h-32 flex items-center justify-center">
            <Image src="/ray-ban-logo-2 (1).svg" alt="#" width={100} height={10} />
          </div>
          <div className="w-32 h-32 flex items-center justify-center">
            <Image src="/wilson-logo (1).svg" alt="#" width={100} height={10} />
          </div>
        </div>
      </section>

      <footer className="bg-white text-black p-6 border-t mt-10">
        <div className="container mx-auto grid grid-cols-1 md:grid-cols-5 gap-6 text-sm">
          {/* Other sections */}
          {/*Connect part*/ }
          <div>
            <h3 className="font-bold">CONNECT</h3>
            <p className="mt-2 text-lg font-bold">+1 800-642-7505 (US)</p>
            <p>Sales and general inquiries</p>
            <button className="text-blue-600 mt-4 border px-4 py-2">Contact Us</button>
          </div>
          {/* Buy Sensomatic */}
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
        <div className="">
          <div className="flex flex-col items-center space-y-4">
            {/* Sensormatic Branding Text */}
            <div className="flex justify-center space-x-1">
              <span className="flex justify-center font-bold text-blue-600">Sensormatic by Johnson Controls</span>
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
