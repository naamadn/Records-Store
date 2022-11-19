export interface Product {
    id: number;
    name: string;
    artist: string;
    price: number;
    pictureUrl: string;
    genre?: string;
    brand: string;
    quantityInStock?: number;
}

export interface ProductParams {
    orderBy: string;
    searchTerm?: string;
    genres: string[];
    brands: string[];
    pageNumber: number;
    pageSize: number;
}