import Image from "next/image";

export default function CustomerLogos() {
  return (
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
          <Image src="/images/puma-logo.png" alt="Puma" width={120} height={50} />
        </div>
        <div className="w-32 h-32 flex items-center justify-center">
          <Image src="/images/claires-logo.png" alt="Claire's" width={120} height={50} />
        </div>
      </div>
    </section>
  );
}
